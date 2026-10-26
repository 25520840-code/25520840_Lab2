using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace _25520840_Lab2
{
    public partial class Form4 : Form
    {
        private List<SinhVien> danhSach = new List<SinhVien>(); //Gọi list sinh viên
        private int viTriHienTai = -1; //Vị trí sinh viên (Chưa chọn ai)

        public Form4()
        {
            InitializeComponent();

            numDiem1.Minimum = 0;
            numDiem1.Maximum = 10;
            numDiem1.DecimalPlaces = 2;

            numDiem2.Minimum = 0;
            numDiem2.Maximum = 10;
            numDiem2.DecimalPlaces = 2;

            numDiem3.Minimum = 0;
            numDiem3.Maximum = 10;
            numDiem3.DecimalPlaces = 2;

            rTxtSinhVien.ReadOnly = true;
            txtAvg.ReadOnly = true;
            txtPage.ReadOnly = true;

            HienThiSinhVien();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string hoTen = txtFullName.Text.Trim();
            string mssv = txtMSSV.Text.Trim();
            string sdt = txtPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ và tên");
                return;
            }

            if (!Regex.IsMatch(mssv, @"^[1-9][0-9]52[0-9]{4}$"))
            {
                MessageBox.Show("MSSV phải có 8 chữ số, dạng xx52xxxx.");
                return;
            }

            if (!Regex.IsMatch(sdt, @"^0[0-9]{9}$"))
            {
                MessageBox.Show(
                    "Điện thoại phải có 10 chữ số và bắt đầu bằng 0.");
                return;
            }

            SinhVien sv = new SinhVien
            {
                HoTen = hoTen,
                MSSV = int.Parse(mssv),
                DienThoai = sdt,
                Diem1 = (float)numDiem1.Value,
                Diem2 = (float)numDiem2.Value,
                Diem3 = (float)numDiem3.Value
            };

            danhSach.Add(sv);
            viTriHienTai = danhSach.Count - 1;

            HienThiSinhVien();

            // Chưa tính điểm trung bình cho sinh viên vừa nhập.
            txtAvg.Clear();

            MessageBox.Show("Đã thêm sinh viên");
        }

        private void btnSaveInput_Click(object sender, EventArgs e)
        {
            if (danhSach.Count == 0)
            {
                MessageBox.Show("Hãy thêm sinh viên trước khi lưu.");
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Lưu danh sách sinh viên";
                dialog.Filter = "Text files (*.txt)|*.txt";
                dialog.FileName = "input4.txt";
                dialog.DefaultExt = "txt";
                dialog.AddExtension = true;

                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        WriteIndented = true
                    };

                    string json = JsonSerializer.Serialize(danhSach, options); //Chuyển các sinh viên trong danhSach thành văn bản JSON

                    using (StreamWriter writer = new StreamWriter(dialog.FileName))
                    {
                        writer.Write(json);
                    }

                    MessageBox.Show("Đã lưu danh sách!");
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

        //Hàm hỗ trợ hiển thị sinh viên
        private void HienThiSinhVien()
        {
            if (danhSach.Count == 0)
            {
                viTriHienTai = -1;

                rTxtSinhVien.Clear();
                txtAvg.Clear();
                txtPage.Text = "0/0";

                btnTruoc.Enabled = false;
                btnSau.Enabled = false;

                return;
            }

            if (viTriHienTai < 0)
            {
                viTriHienTai = 0;
            }
            else if (viTriHienTai >= danhSach.Count)
            {
                viTriHienTai = danhSach.Count - 1;
            }

            SinhVien sv = danhSach[viTriHienTai];

            rTxtSinhVien.Text =
                $"Họ Tên: {sv.HoTen}{Environment.NewLine}" +
                $"MSSV: {sv.MSSV}{Environment.NewLine}" +
                $"Số điện thoại: {sv.DienThoai}{Environment.NewLine}" +
                $"Điểm môn thứ nhất: {sv.Diem1}{Environment.NewLine}" +
                $"Điểm môn thứ hai: {sv.Diem2}{Environment.NewLine}" +
                $"Điểm môn thứ ba: {sv.Diem3}{Environment.NewLine}";

            txtAvg.Text = sv.DiemTrungBinh.ToString("0.00");
            txtPage.Text = $"{viTriHienTai + 1}/{danhSach.Count}";

            btnTruoc.Enabled = viTriHienTai > 0;
            btnSau.Enabled = viTriHienTai < danhSach.Count - 1;
        }

        //Hàm kiểm tra tính hợp lệ của điểm
        private bool DiemHopLe(float diem)
        {
            return !float.IsNaN(diem) && diem >= 0 && diem <= 10;
        }

        //Nút đọc file và tính toán dữ liệu
        private void btnCalc_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Đọc danh sách sinh viên";
                dialog.Filter = "Text files (*.txt)|*.txt";
                dialog.FileName = "input4.txt";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    string json;

                    using (StreamReader reader = new StreamReader(dialog.FileName))
                    {
                        json = reader.ReadToEnd();
                    }

                    List<SinhVien> duLieu =
                        JsonSerializer.Deserialize<List<SinhVien>>(json);

                    if (duLieu == null || duLieu.Count == 0)
                    {
                        MessageBox.Show("File không có sinh viên.");
                        return;
                    }

                    foreach (SinhVien sv in duLieu)
                    {
                        if (sv == null ||
                            string.IsNullOrWhiteSpace(sv.HoTen) ||
                            !Regex.IsMatch(
                                sv.MSSV.ToString(),
                                @"^[1-9][0-9]52[0-9]{4}$") ||
                            !Regex.IsMatch(
                                sv.DienThoai ?? "",
                                @"^0[0-9]{9}$") ||
                            !DiemHopLe(sv.Diem1) ||
                            !DiemHopLe(sv.Diem2) ||
                            !DiemHopLe(sv.Diem3))
                        {
                            throw new FormatException(
                                "File chứa thông tin sinh viên không hợp lệ.");
                        }

                        sv.DiemTrungBinh =
                            (sv.Diem1 + sv.Diem2 + sv.Diem3) / 3f;
                    }

                    danhSach = duLieu;
                    viTriHienTai = 0;

                    HienThiSinhVien();

                    MessageBox.Show(
                        "Đã đọc danh sách và tính điểm trung bình!");
                }
                catch (JsonException ex)
                {
                    MessageBox.Show(
                        "JSON không đúng định dạng: " + ex.Message);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(
                        "Không thể đọc file: " + ex.Message);
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(
                        "Không có quyền đọc file: " + ex.Message);
                }
            }
        }

        //Nút <<
        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (viTriHienTai > 0)
            {
                viTriHienTai--;
                HienThiSinhVien();
            }
        }

        //Nút >>
        private void btnSau_Click(object sender, EventArgs e)
        {
            if (viTriHienTai < danhSach.Count - 1)
            {
                viTriHienTai++;
                HienThiSinhVien();
            }
        }

        //Nút lưu danh sách
        private void btnOutput_Click(object sender, EventArgs e)
        {
            if (danhSach.Count == 0)
            {
                MessageBox.Show("Danh sách chưa có sinh viên.");
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Xuất danh sách kết quả";
                dialog.Filter = "Text files (*.txt)|*.txt";
                dialog.FileName = "output4.txt";
                dialog.DefaultExt = "txt";
                dialog.AddExtension = true;

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    //Kiểm tra phép toán lại trước khi xuất file
                    foreach (SinhVien sv in danhSach)
                    {
                        sv.DiemTrungBinh =
                            (sv.Diem1 + sv.Diem2 + sv.Diem3) / 3f;
                    }

                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        WriteIndented = true
                    };

                    string json =
                        JsonSerializer.Serialize(danhSach, options);

                    using (StreamWriter writer = new StreamWriter(dialog.FileName))
                    {
                        writer.Write(json);
                    }

                    HienThiSinhVien();

                    MessageBox.Show(
                        "Đã xuất danh sách và điểm trung bình!");
                }
                catch (IOException ex)
                {
                    MessageBox.Show(
                        "Không thể ghi file: " + ex.Message);
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(
                        "Không có quyền ghi file: " + ex.Message);
                }
            }
        }
    }
}