using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace _25520840_Lab2
{
    public partial class Form5 : Form
    {
        //Dictionary for Film price, Film room and Seat Price
        Dictionary<string, decimal> giaPhim = new Dictionary<string, decimal>();
        Dictionary<string, int[]> phongPhim = new Dictionary<string, int[]>();
        Dictionary<string, decimal> heSoGhe = new Dictionary<string, decimal>()
        {
            {"A1",0.25m },
            {"A2",1m },
            {"A3",1m },
            {"A4",1m },
            {"A5",0.25m },

            {"B1",1m },
            {"B2",2m },
            {"B3",2m },
            {"B4",2m },
            {"B5",1m },

            {"C1",0.25m },
            {"C2",1m },
            {"C3",1m },
            {"C4",1m },
            {"C5",0.25m }
        };

        Dictionary<string, decimal> doanhthuPhim = new Dictionary<string, decimal>();

        /*
        Dictionary to know whether the customer has bought a product or not
        Full Examples: Customer name -> {room number -> number of tickets bought}
        */
        Dictionary<string, Dictionary<int, int>> lichsuMua = new Dictionary<string, Dictionary<int, int>>(StringComparer.OrdinalIgnoreCase);

        //Dictionary to find out whether the seat was sold or not
        Dictionary<string, HashSet<string>> gheDaBan = new Dictionary<string, HashSet<string>>();

        //Main function
        public Form5()
        {
            InitializeComponent();

            cboPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhong.DropDownStyle = ComboBoxStyle.DropDownList;

            CapNhatGhe();
        }

        private void CapNhatGhe()
        {
            string key = null;
            if (cboPhim.SelectedItem != null && cboPhong.SelectedItem != null)
            {
                key = cboPhim.SelectedItem.ToString() + "|" + cboPhong.SelectedItem.ToString();
            }

            foreach (Control control in tlbGhe.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox ghe = (CheckBox)control;
                    ghe.Checked = false;

                    bool daBan = key != null && gheDaBan.ContainsKey(key) && gheDaBan[key].Contains(ghe.Name);
                    ghe.Enabled = key != null && !daBan;
                }
            }
        }
        //Check box film Functions
        private void cboPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPhong.Items.Clear();
            CapNhatGhe();
            if (cboPhim.SelectedItem == null)
            {
                return;
            }

            string tenPhim = cboPhim.SelectedItem.ToString();

            foreach (int phong in phongPhim[tenPhim])
            {
                cboPhong.Items.Add(phong);
            }
        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatGhe();
        }
        //Confirming to buy tickets
        private void btnMuaVe_Click(object sender, EventArgs e)
        {
            //Checking whether customer had written their name yet
            string HoTen = txtHoTen.Text.Trim();

            if (string.IsNullOrWhiteSpace(HoTen))
            {
                MessageBox.Show("Vui long nhap ho va ten!");
                return;
            }

            //Checking whether the customer had picked a film and a room or not
            if (cboPhim.SelectedItem == null || cboPhong.SelectedItem == null)
            {
                MessageBox.Show("Vui long chon phim va phong chieu.");
                return;
            }

            //Adding picked seats
            List<string> gheDaChon = new List<string>();

            foreach (Control control in tlbGhe.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox ghe = (CheckBox)control;
                    if (ghe.Checked)
                    {
                        gheDaChon.Add(ghe.Name);
                    }
                }
            }

            //Checking whether the customer had chosen a seat or not
            if (gheDaChon.Count == 0)
            {
                MessageBox.Show("Vui long chon it nhat mot ghe.");
                return;
            }

            //Checking customer buying history
            int phongHienTai = (int)cboPhong.SelectedItem;
            //Copy previous purchases so validation doesn't change the history
            Dictionary<int, int> duKien;

            if (lichsuMua.ContainsKey(HoTen))
            {
                duKien = new Dictionary<int, int>(lichsuMua[HoTen]);
            }
            else
            {
                duKien = new Dictionary<int, int>();
            }

            //Checking whether having a current room or not
            if (!duKien.ContainsKey(phongHienTai))
            {
                duKien[phongHienTai] = 0;
            }

            duKien[phongHienTai] += gheDaChon.Count;

            //Adding the total ammount of seats
            int TongSoVe = 0;

            foreach (int soVe in duKien.Values)
            {
                TongSoVe += soVe;
            }

            //Checking requirements
            if (duKien.Count > 1 && TongSoVe > 2)
            {
                MessageBox.Show("Khong duoc mua qua 2 ve o cac phong chieu khac nhau.");
                return;
            }

            //Checking bought history
            string tenPhim = cboPhim.SelectedItem.ToString();
            string key = tenPhim + "|" + phongHienTai;

            foreach (string maGhe in gheDaChon)
            {
                if (gheDaBan.ContainsKey(key) && gheDaBan[key].Contains(maGhe))
                {
                    MessageBox.Show("Seats: " + maGhe + "has/have been sold");
                    return;
                }
            }
            //Calculating the total price
            decimal GiaChuan = giaPhim[tenPhim];
            decimal tongTien = 0m;

            foreach (string maGhe in gheDaChon)
            {
                tongTien += GiaChuan * heSoGhe[maGhe];
            }

            if (!gheDaBan.ContainsKey(key))
            {
                gheDaBan[key] = new HashSet<string>();
            }

            foreach (string maGhe in gheDaChon)
            {
                gheDaBan[key].Add(maGhe);
            }

            //Adding items into buying history
            lichsuMua[HoTen] = duKien;

            //Update revenue after a purchase
            if (!doanhthuPhim.ContainsKey(tenPhim))
            {
                doanhthuPhim[tenPhim] = 0m;
            }

            doanhthuPhim[tenPhim] += tongTien;

            //Printing results on the screen
            txtKetQua.Text =
                "Customer: " + HoTen
                + "\r\nFilm: " + tenPhim
                + "\r\nRoom: " + phongHienTai
                + "\r\nSeats: " + string.Join(", ", gheDaChon)
                + "\r\nTotal: " + tongTien.ToString("N0") + "đ";
            CapNhatGhe();
        }

        //Input film button
        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            if (gheDaBan.Count > 0)
            {
                MessageBox.Show("Đã có vé được bán. Không thể thay danh sách phim trong phiên này.");
                return;
            }

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Read film list";
                dialog.Filter = "Text files (*.txt)|*.txt";
                dialog.FileName = "input5.txt";

                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    string[] lines = File.ReadAllLines(dialog.FileName, Encoding.UTF8);

                    if (lines.Length == 0 || lines.Length % 3 != 0)
                    {
                        throw new FormatException("Mỗi phim phải có đúng 3 dòng: tên, giá, phòng chiếu");
                    }

                    //Read temp input files in order to prevent data loss
                    Dictionary<string, decimal> giaMoi = new Dictionary<string, decimal>();

                    Dictionary<string, int[]> phongMoi = new Dictionary<string, int[]>();

                    for (int i = 0; i < lines.Length; i += 3)
                    {
                        string tenPhim = lines[i].Trim();

                        if (string.IsNullOrWhiteSpace(tenPhim))
                            throw new FormatException("Tên phim không được trống.");

                        if (giaMoi.ContainsKey(tenPhim))
                            throw new FormatException("Tên phim bị trùng: " + tenPhim);

                        decimal gia;

                        if (!decimal.TryParse(lines[i + 1].Trim(),
                                              NumberStyles.AllowDecimalPoint,
                                              CultureInfo.InvariantCulture,
                                              out gia) || gia <= 0)
                        {
                            throw new FormatException("Giá vé không hợp lệ của phim: " + tenPhim);
                        }

                        string[] cacPhong = lines[i + 2].Split(',');

                        List<int> danhsachPhong = new List<int>();

                        foreach (string chuoiPhong in cacPhong)
                        {
                            int phong;

                            if (!int.TryParse(chuoiPhong.Trim(), out phong) || phong < 1 || phong > 3)
                            {
                                throw new FormatException("Phòng chiếu phải là 1, 2 hoặc 3.");
                            }

                            if (danhsachPhong.Contains(phong))
                            {
                                throw new FormatException("Phòng chiếu bị trùng trong phim: " + tenPhim);
                            }

                            danhsachPhong.Add(phong);
                        }

                        giaMoi.Add(tenPhim, gia);
                        phongMoi.Add(tenPhim, danhsachPhong.ToArray());
                    }

                    cboPhim.SelectedIndex = -1;
                    cboPhong.SelectedIndex = -1;
                    cboPhim.Items.Clear();
                    cboPhong.Items.Clear();

                    giaPhim = giaMoi;
                    phongPhim = phongMoi;

                    foreach (string tenPhim in giaPhim.Keys)
                    {
                        cboPhim.Items.Add(tenPhim);
                    }

                    txtKetQua.Clear();
                    CapNhatGhe();

                    MessageBox.Show("Đã đọc danh sách phim!");
                }

                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                catch (IOException ex)
                {
                    MessageBox.Show("Không thể đọc file: " + ex.Message);
                }

                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show("Không có quyền đọc file: " + ex.Message);
                }
            }
        }

        private void btnAddFilmInfo_Click(object sender, EventArgs e)
        {
            if (gheDaBan.Count > 0)
            {
                MessageBox.Show("Đã có vé được bán. Không thể thêm phim trong phiên này.");
                return;
            }

            string tenPhim = txtNewFilmName.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenPhim))
            {
                MessageBox.Show("Vui lòng nhập tên phim.");
                return;
            }

            if (tenPhim.Contains("\r") || tenPhim.Contains("\n"))
            {
                MessageBox.Show("Tên phim phải nằm trên một dòng.");
                return;
            }

            foreach (string tenDaCo in giaPhim.Keys)
            {
                if (string.Equals(tenDaCo, tenPhim, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Phim này đã có trong danh sách");
                    return;
                }
            }

            decimal gia = numTicketPrice.Value;

            if (gia <= 0)
            {
                MessageBox.Show("Giá vé phải lớn hơn 0.");
                return;
            }

            if (clbFilmRooms.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một phòng chiếu.");
                return;
            }

            List<int> cacPhong = new List<int>();

            foreach (object item in clbFilmRooms.CheckedItems)
            {
                int Phong;

                if (!int.TryParse(item.ToString(), out Phong)
                        || Phong < 1 || Phong > 3)
                {
                    MessageBox.Show("Phòng chiếu phải là 1, 2 hoặc 3.");
                    return;
                }

                if (!cacPhong.Contains(Phong))
                {
                    cacPhong.Add(Phong);
                }
            }

            cacPhong.Sort();

            giaPhim.Add(tenPhim, gia);
            phongPhim.Add(tenPhim, cacPhong.ToArray());

            //Update the film selection list
            cboPhim.Items.Add(tenPhim);

            txtNewFilmName.Clear();

            for (int i = 0; i < clbFilmRooms.Items.Count; i++)
            {
                clbFilmRooms.SetItemChecked(i, false);
            }

            MessageBox.Show("Đã thêm phim!");
        }

        private void btnSaveFilms_Click(object sender, EventArgs e)
        {
            if (giaPhim.Count == 0)
            {
                MessageBox.Show("Hãy thêm phim trước khi lưu.");
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Lưu danh sách phim";
                dialog.Filter = "Text files (*.txt)|*.txt";
                dialog.FileName = "input5.txt";
                dialog.DefaultExt = "txt";
                dialog.AddExtension = true;

                if (dialog.ShowDialog() != DialogResult.OK) return;

                try
                {
                    using (StreamWriter writer = new StreamWriter(dialog.FileName, false, Encoding.UTF8))
                    {
                        foreach (string tenPhim in giaPhim.Keys)
                        {
                            writer.WriteLine(tenPhim);

                            writer.WriteLine(giaPhim[tenPhim].ToString(CultureInfo.InvariantCulture));

                            writer.WriteLine(string.Join(",", phongPhim[tenPhim]));
                        }
                    }
                    MessageBox.Show("Đã lưu danh sách phim!");
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Không thể ghi file: " + ex.Message);
                }

                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show("Không có quyền ghi file: " + ex.Message);
                }
            }
        }

        private async void btnExportRevenue_Click(object sender, EventArgs e)
        {
            if (giaPhim.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu phim.");
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Xuất thống kê phòng vé";
                dialog.Filter = "Text files (*.txt)|*.txt";
                dialog.FileName = "output5.txt";
                dialog.DefaultExt = "txt";
                dialog.AddExtension = true;

                if (dialog.ShowDialog() != DialogResult.OK) return;

                //Sort films by revenue, highest first
                List<string> phimDaSapXep = giaPhim.Keys.OrderByDescending(ten => doanhthuPhim.ContainsKey(ten) ? doanhthuPhim[ten] : 0m).ThenBy(ten => ten).ToList();

                pbExport.Minimum = 0;
                pbExport.Maximum = phimDaSapXep.Count;
                pbExport.Value = 0;
                pbExport.Style = ProgressBarStyle.Blocks;

                this.Enabled = false;

                try
                {
                    using (StreamWriter writer = new StreamWriter(dialog.FileName, false, Encoding.UTF8)) 
                    {
                        await writer.WriteLineAsync("THỐNG KÊ PHÒNG VÉ");
                        await writer.WriteLineAsync();

                        int viTri = 0;
                        int hang = 0;
                        decimal? doanhthuTruoc = null;

                        foreach (string tenPhim in phimDaSapXep)
                        {
                            viTri++;

                            decimal doanhthu = doanhthuPhim.ContainsKey(tenPhim) ? doanhthuPhim[tenPhim] : 0m;

                            //Films with the same revenue rank the same

                            if (!doanhthuTruoc.HasValue || doanhthu != doanhthuTruoc.Value)
                            {
                                hang = viTri;
                            }

                            doanhthuTruoc = doanhthu;

                            int veBan = 0;

                            foreach (int phong in phongPhim[tenPhim])
                            {
                                string key = tenPhim + "|" + phong;

                                if (gheDaBan.ContainsKey(key))
                                {
                                    veBan += gheDaBan[key].Count;
                                }
                            }

                            int tongVe = phongPhim[tenPhim].Length * heSoGhe.Count;

                            int veTon = tongVe - veBan;

                            double tiLe = tongVe > 0 ? (double)veBan / tongVe * 100 : 0;

                            string thongKe =
                                $"Tên phim: {tenPhim}{Environment.NewLine}" +
                                $"Số vé bán: {veBan}{Environment.NewLine}" +
                                $"Số vé tồn: {veTon}{Environment.NewLine}" +
                                $"Tỉ lệ bán: {tiLe:F2}%{Environment.NewLine}" +
                                $"Doanh thu: {doanhthu:N0} đ{Environment.NewLine}" +
                                $"Xếp hạng doanh thu: {hang}{Environment.NewLine}" +
                                "--------------------------------";

                            await writer.WriteLineAsync(thongKe);
                            await writer.FlushAsync();

                            pbExport.Value = viTri;
                            pbExport.Refresh();
                        }
                    }
                    MessageBox.Show("Đã xuất thống kê!");
                }

                catch (IOException ex)
                {
                    pbExport.Value = 0;
                    MessageBox.Show("Không thể ghi file: " + ex.Message);
                }

                catch (UnauthorizedAccessException ex)
                {
                    pbExport.Value = 0;
                    MessageBox.Show("Không có quyền ghi file: " + ex.Message);
                }

                finally
                {
                    this.Enabled = true;
                }
            }
        }
    }
}
