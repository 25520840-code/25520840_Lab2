using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.IO;

namespace _25520840_Lab2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            try
            {
                KhoiTaoDatabase();
                TaiNguoiDongGop();
                TaiDanhSachMon();
            }

            catch (SqliteException ex)
            {
                MessageBox.Show("Lỗi SQLite: " + ex.Message);

                btnAddName.Enabled = false;
                btnAdd.Enabled = false;
                btnRandom.Enabled = false;
                btnDelete.Enabled = false;
            }

            catch (IOException ex)
            {
                MessageBox.Show("Không thể tạo database: " + ex.Message);
            }

            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Không có quyền tạo database: " + ex.Message);
            }
        }

        private readonly string connectionString = new SqliteConnectionStringBuilder
        {
            DataSource = Path.Combine(Application.LocalUserAppDataPath, "food.db"),
            ForeignKeys = true
        }.ToString();
        private void KhoiTaoDatabase()
        {
            Directory.CreateDirectory(Application.LocalUserAppDataPath);

            using (SqliteConnection connection =
                new SqliteConnection(connectionString))
            {
                connection.Open();

                using (SqliteCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"
                                            CREATE TABLE IF NOT EXISTS NguoiDung
                                            (
                                                IDNCC INTEGER PRIMARY KEY AUTOINCREMENT,
                                                HoVaTen TEXT NOT NULL,
                                                QuyenHan TEXT NOT NULL
                                            );

                                            CREATE TABLE IF NOT EXISTS MonAn
                                            (
                                                IDMA INTEGER PRIMARY KEY AUTOINCREMENT,
                                                TenMonAn TEXT NOT NULL,
                                                HinhAnh TEXT NOT NULL,
                                                IDNCC INTEGER NOT NULL,
                                                FOREIGN KEY (IDNCC) REFERENCES NguoiDung(IDNCC)
                                            );
                                         ";

                    command.ExecuteNonQuery();

                    // Check column
                    command.CommandText = "PRAGMA table_info(MonAn);";

                    bool coCotHinhAnh = false;

                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (string.Equals(
                                reader.GetString(1),
                                "HinhAnh",
                                StringComparison.OrdinalIgnoreCase))
                            {
                                coCotHinhAnh = true;
                            }
                        }
                    }

                    // Add column 
                    if (!coCotHinhAnh)
                    {
                        command.CommandText = @"
                                                ALTER TABLE MonAn
                                                ADD COLUMN HinhAnh TEXT NOT NULL DEFAULT '';
                                              ";

                        command.ExecuteNonQuery();
                    }
                }
            }
        }


        private void TaiNguoiDongGop()
        {
            DataTable table = new DataTable();

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                using (SqliteCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT IDNCC, HoVaTen FROM NguoiDung ORDER BY IDNCC;";

                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        table.Load(reader);
                    }
                }
            }

            cboName.DataSource = table;
            cboName.DisplayMember = "HoVaTen";
            cboName.ValueMember = "IDNCC";
            cboName.SelectedIndex = -1;
        }

        private void TaiDanhSachMon()
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                using (SqliteCommand command = connection.CreateCommand())
                {
                    command.CommandText =
                        @"
                        SELECT m.IDMA, m.TenMonAn, n.HoVaTen
                        FROM MonAn AS m
                        JOIN NguoiDung AS n ON m.IDNCC = n.IDNCC
                        ORDER BY m.IDMA;
                        ";

                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        lvFoodList.Items.Clear();
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader.GetInt64(0).ToString());

                            item.SubItems.Add(reader.GetString(1));
                            item.SubItems.Add(reader.GetString(2));

                            item.Tag = reader.GetInt64(0);
                            lvFoodList.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void HienThiAnh(string path)
        {
            Image anhCu = pcbFoodPic.Image;
            pcbFoodPic.Image = null;
            anhCu?.Dispose();

            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                return;
            }

            try
            {
                using (Image anhGoc = Image.FromFile(path))
                {
                    //Make copy to protect pic in database
                    pcbFoodPic.Image = new Bitmap(anhGoc);
                }
            }

            catch (ArgumentException)
            {
                MessageBox.Show("Ảnh món ăn không hợp lệ.");
            }

            catch (OutOfMemoryException)
            {
                MessageBox.Show("Ảnh bị lỗi hoặc không đủ bộ nhớ.");
            }

            catch (IOException ex)
            {
                MessageBox.Show("Không thể đọc ảnh: " + ex.Message);
            }

            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Không có quyền đọc ảnh: " + ex.Message);
            }
        }
        private void btnAddName_Click(object sender, EventArgs e)
        {
            string hoTen = txtAddName.Text.Trim();

            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Vui lòng nhập tên người đóng góp.");
                txtAddName.Focus();
                return;
            }

            try
            {
                long idMoi;

                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    connection.Open();

                    using (SqliteCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"
                                                INSERT INTO NguoiDung (HoVaTen, QuyenHan)
                                                VALUES ($hoTen, $quyenHan);
                                              ";

                        command.Parameters.AddWithValue("$hoTen", hoTen);

                        command.Parameters.AddWithValue("$quyenHan", "ThanhVien");
                        command.ExecuteNonQuery();

                        command.Parameters.Clear();
                        command.CommandText = "SELECT last_insert_rowid();";

                        idMoi = (long)command.ExecuteScalar();
                    }
                }

                TaiNguoiDongGop();

                //Choose the person just added
                cboName.SelectedValue = idMoi;
                txtAddName.Clear();
                MessageBox.Show("Đã thêm người đóng góp!");
            }

            catch (SqliteException ex)
            {
                MessageBox.Show("Không thể thêm người đóng góp: " + ex.Message);
            }
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Chọn ảnh món ăn";
                dialog.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp";

                if (dialog.ShowDialog() != DialogResult.OK) return;

                try
                {
                    //Read whether file is image or not
                    using (Image image = Image.FromFile(dialog.FileName))
                    {
                        txtPictureLink.Text = dialog.FileName;
                    }

                    MessageBox.Show("Đã chọn ảnh cho món ăn.");
                }

                catch (ArgumentException)
                {
                    MessageBox.Show("File đã chọn không phải ảnh hợp lệ.");
                }

                catch (OutOfMemoryException)
                {
                    MessageBox.Show("Ảnh bị lỗi hoặc không đủ bộ nhớ.");
                }

                catch (IOException ex)
                {
                    MessageBox.Show("Không thể đọc ảnh: " + ex.Message);
                }

                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show("Không có quyền đọc file ảnh: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenMon = txtAddFood.Text.Trim();
            string anhGoc = txtPictureLink.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenMon))
            {
                MessageBox.Show("Vui lòng nhập món ăn!");

                txtAddFood.Focus();

                return;
            }

            if (cboName.SelectedIndex < 0 || cboName.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn người đóng góp");
                return;
            }

            if (!File.Exists(anhGoc))
            {
                MessageBox.Show("Vui lòng chọn ảnh món ăn còn tồn tại.");
                return;
            }

            string anhLuu = "";
            bool daLuuDatabase = false;

            try
            {
                long idNguoiDongGop = Convert.ToInt64(cboName.SelectedValue);

                string thuMucAnh = Path.Combine(Application.LocalUserAppDataPath, "Images");

                Directory.CreateDirectory(thuMucAnh);

                //Create a different name for pictures that have the same name in the first place to prevent overwrite

                string tenAnh = Guid.NewGuid().ToString("N") + Path.GetExtension(anhGoc);

                anhLuu = Path.Combine(thuMucAnh, tenAnh);

                File.Copy(anhGoc, anhLuu);

                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    connection.Open();

                    using (SqliteCommand command = connection.CreateCommand())
                    {
                        command.CommandText =
                        @"
                        INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC)
                        VALUES ($tenMonAn, $hinhAnh, $idNguoi);
                        ";

                        command.Parameters.AddWithValue("$tenMonAn", tenMon);
                        command.Parameters.AddWithValue("$hinhAnh", anhLuu);
                        command.Parameters.AddWithValue("$idNguoi", idNguoiDongGop);

                        command.ExecuteNonQuery();
                        daLuuDatabase = true;
                    }
                }
            }

            catch (SqliteException ex)
            {
                MessageBox.Show("Không thể lưu món ăn: " + ex.Message);
            }

            catch (IOException ex)
            {
                MessageBox.Show("Không thể sao chép ảnh: " + ex.Message);
            }

            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Không có quyền truy cập ảnh: " + ex.Message);
            }

            finally
            {
                //If failed to save database, deleted the picture just got copied

                if (!daLuuDatabase && File.Exists(anhLuu))
                {
                    try
                    {
                        File.Delete(anhLuu);
                    }

                    catch (IOException) { }
                    catch (UnauthorizedAccessException) { }
                }
            }

            if (!daLuuDatabase) return;

            txtAddFood.Clear();
            txtPictureLink.Clear();
            txtAddFood.Focus();

            try
            {
                TaiDanhSachMon();
                MessageBox.Show("Đã thêm món ăn!");
            }

            catch (SqliteException ex)
            {
                MessageBox.Show("Món đã lưu nhưng chưa tải lại được danh sách: " + ex.Message);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            try
            {
                string tenMon;
                string nguoiDongGop;
                string hinhAnh;

                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    connection.Open();

                    using (SqliteCommand command = connection.CreateCommand())
                    {
                        command.CommandText =
                            @"
                            SELECT m.TenMonAn, n.HoVaTen, m.HinhAnh
                            FROM MonAn AS m
                            JOIN NguoiDung AS n ON m.IDNCC = n.IDNCC
                            ORDER BY RANDOM()
                            LIMIT 1;
                            ";

                        using (SqliteDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                txtRandRes.Clear();
                                txtResultName.Clear();

                                Image anhCu = pcbFoodPic.Image;
                                pcbFoodPic.Image = null;
                                anhCu?.Dispose();

                                MessageBox.Show("Chưa có món ăn. Hãy thêm món trước!");

                                return;
                            }

                            tenMon = reader.GetString(0);
                            nguoiDongGop = reader.GetString(1);
                            hinhAnh = reader.GetString(2);
                        }
                    }
                }
                txtRandRes.Text = tenMon;
                txtResultName.Text = nguoiDongGop;

                HienThiAnh(hinhAnh);
            }

            catch (SqliteException ex)
            {
                MessageBox.Show("Không thể chọn món ăn: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvFoodList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món cần xóa trong danh sách.");
                return;
            }

            ListViewItem item = lvFoodList.SelectedItems[0];

            long idMon = Convert.ToInt64(item.Tag);
            string tenKMon = item.SubItems[1].Text;

            DialogResult result = MessageBox.Show("Xóa món \"" + tenKMon + "\"?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            try
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    connection.Open();

                    using (SqliteCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "DELETE FROM MonAn WHERE IDMA = $id;";

                        command.Parameters.AddWithValue("$id", idMon);

                        command.ExecuteNonQuery();
                    }
                }
            }

            catch (SqliteException ex)
            {
                MessageBox.Show("Không thể xóa món: " + ex.Message);
                return;
            }

            //Delete all old random preventing to be shown on screen

            txtRandRes.Clear();
            txtResultName.Clear();

            Image anhCu = pcbFoodPic.Image;
            pcbFoodPic.Image = null;
            anhCu?.Dispose();

            try
            {
                TaiDanhSachMon();
                MessageBox.Show("Đã xóa món ăn!");
            }

            catch (SqliteException ex)
            {
                MessageBox.Show("Món đã được xóa nhưng chưa tải lại được danh sách: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Image anhCu = pcbFoodPic.Image;
            pcbFoodPic.Image = null;
            anhCu?.Dispose();

            base.OnFormClosed(e);
        }
    }
}
