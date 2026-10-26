using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace _25520840_Lab2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private int UuTien(char op)
        {
            if (op == '+' || op == '-') return 1;
            if (op == '*' || op == '/') return 2;
            if (op == '~') return 3;

            return 0;
        }

        /*
        Begin of calculate functions
        */
        private void TinhPhanTu(Stack<double> so, Stack<char> op)
        {
            if (op.Count == 0)
                throw new FormatException("Thiếu toán tử.");

            char phepTinh = op.Pop();

            // Dấu âm đơn ngôi chỉ cần một toán hạng.
            if (phepTinh == '~')
            {
                if (so.Count < 1)
                    throw new FormatException("Thiếu toán hạng.");

                so.Push(-so.Pop());
                return;
            }

            if (so.Count < 2)
                throw new FormatException("Thiếu toán hạng.");

            double a = so.Pop(); // Số bên phải
            double b = so.Pop(); // Số bên trái

            switch (phepTinh)
            {
                case '+':
                    so.Push(b + a);
                    break;

                case '-':
                    so.Push(b - a);
                    break;

                case '*':
                    so.Push(b * a);
                    break;

                case '/':
                    if (a == 0)
                        throw new DivideByZeroException("Không thể chia cho 0.");

                    so.Push(b / a);
                    break;

                default:
                    throw new FormatException("Toán tử không hợp lệ.");
            }
        }

        private double TinhGiaTri(string dathuc)
        {
            Stack<double> so = new Stack<double>();
            Stack<char> op = new Stack<char>();

            bool kitutruoclaso = false;

            for (int i = 0; i < dathuc.Length; i++)
            {
                char c = dathuc[i];

                if (char.IsWhiteSpace(c))
                    continue;

                // Đọc số nguyên hoặc số thập phân.
                if ((c >= '0' && c <= '9') || c == '.')
                {
                    if (kitutruoclaso)
                        throw new FormatException("Thiếu toán tử giữa hai số.");

                    int start = i;

                    while (i < dathuc.Length &&
                           ((dathuc[i] >= '0' && dathuc[i] <= '9') ||
                            dathuc[i] == '.'))
                    {
                        i++;
                    }

                    string chuoiSo = dathuc.Substring(start, i - start);

                    if (!double.TryParse(
                            chuoiSo,
                            NumberStyles.AllowDecimalPoint,
                            CultureInfo.InvariantCulture,
                            out double value))
                    {
                        throw new FormatException("Số không hợp lệ.");
                    }

                    so.Push(value);
                    i--;
                    kitutruoclaso = true;
                }
                else if (c == '(')
                {
                    if (kitutruoclaso)
                        throw new FormatException("Thiếu toán tử trước dấu '('.");

                    op.Push(c);
                    kitutruoclaso = false;
                }
                else if (c == ')')
                {
                    if (!kitutruoclaso)
                        throw new FormatException("Thiếu toán hạng trước dấu ')'.");

                    while (op.Count > 0 && op.Peek() != '(')
                    {
                        TinhPhanTu(so, op);
                    }

                    if (op.Count == 0)
                        throw new FormatException("Ngoặc không khớp.");

                    op.Pop(); // Bỏ '('.
                    kitutruoclaso = true;
                }
                else if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    if (!kitutruoclaso)
                    {
                        // Dấu âm đơn ngôi.
                        if (c == '-')
                            op.Push('~');
                        else if (c != '+')
                            throw new FormatException("Thiếu toán hạng.");

                        // Dấu cộng đơn ngôi không làm đổi giá trị.
                        continue;
                    }

                    while (op.Count > 0 &&
                           op.Peek() != '(' &&
                           UuTien(op.Peek()) >= UuTien(c))
                    {
                        TinhPhanTu(so, op);
                    }

                    op.Push(c);
                    kitutruoclaso = false;
                }
                else
                {
                    throw new FormatException("Ký tự không hợp lệ: " + c);
                }
            }

            if (!kitutruoclaso)
                throw new FormatException("Biểu thức rỗng hoặc thiếu toán hạng.");

            while (op.Count > 0)
            {
                if (op.Peek() == '(')
                    throw new FormatException("Ngoặc không khớp.");

                TinhPhanTu(so, op);
            }

            if (so.Count != 1)
                throw new FormatException("Biểu thức không hợp lệ.");

            return so.Pop();
        }

        /*
        End of calculate function
        */
        private void btnCalc_Click(object sender, EventArgs e)
        {
            rTxt_Output.Clear();

            using (StringReader reader = new StringReader(rTxt_Input.Text))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    try
                    {
                        double result = TinhGiaTri(line);

                        rTxt_Output.AppendText(
                            line + " = " +
                            result.ToString(CultureInfo.InvariantCulture) +
                            Environment.NewLine);
                    }
                    catch (FormatException ex)
                    {
                        rTxt_Output.AppendText(
                            line + " = Lỗi: " + ex.Message +
                            Environment.NewLine);
                    }
                    catch (DivideByZeroException ex)
                    {
                        rTxt_Output.AppendText(
                            line + " = Lỗi: " + ex.Message +
                            Environment.NewLine);
                    }
                }
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Chọn file biểu thức";
                dialog.Filter = "Text files (*.txt)|*.txt";
                dialog.FileName = "input3.txt";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (StreamReader reader = new StreamReader(dialog.FileName))
                    {
                        rTxt_Input.Text = reader.ReadToEnd();
                    }

                    // Xóa kết quả của lần tính trước.
                    rTxt_Output.Clear();
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
        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rTxt_Output.Text))
            {
                MessageBox.Show("Hãy tính kết quả trước khi lưu.");
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Lưu kết quả";
                dialog.Filter = "Text files (*.txt)|*.txt";
                dialog.FileName = "output3.txt";
                dialog.DefaultExt = "txt";
                dialog.AddExtension = true;

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (StreamWriter writer = new StreamWriter(dialog.FileName))
                    {
                        writer.Write(rTxt_Output.Text);
                    }

                    MessageBox.Show("Đã lưu kết quả!");
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
    }
}
