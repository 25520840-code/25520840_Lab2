namespace _25520840_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Input_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog()) //OpenFileDialog tạo hộp thoại chọn file
            {
                dialog.Title = "Chọn file văn bản"; //Basically creating a Title for the dialog
                dialog.Filter = "Text files (*.txt) |*.txt|All files (*.*)|*.*"; //Lọc file hiển thị

                if (dialog.ShowDialog() == DialogResult.OK) //mở hộp thoại chọn file và đọc các file người dùng nhập khi người dùng xác nhận thông qua nhấn Open 
                {
                    string path = dialog.FileName; //Đường dẫn đầy đủ

                    using (StreamReader reader = new StreamReader(path)) //Mở file 
                    {
                        rTxt_Input.Text = reader.ReadToEnd(); //Đọc hết file và lưu vào rTxt_Input
                    }
                }
            }
        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {
            rTxt_Output.Text = rTxt_Input.Text.ToUpper(); //Uppercasing
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog()) //SaveFileDialog cho chọn vị trí và tên file cần lưu
            {
                dialog.Title = "Lưu kết quả"; //Basically title
                dialog.Filter = "Text files (*.txt)|*.txt"; //Filtering files

                dialog.FileName = "output1.txt"; //Name of the output files
                dialog.DefaultExt = "txt"; 
                dialog.AddExtension = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(dialog.FileName)) //Open file to write, default overwrite if already have file
                    {
                        writer.Write(rTxt_Output.Text); //Basically write
                    }
                }

                MessageBox.Show("Đã lưu file!");
            }
        }
    }
}
