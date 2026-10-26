using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace _25520840_Lab2
{
    public partial class Form7 : Form
    {
        private string duongDanHienTai = "";
        public Form7()
        {
            InitializeComponent();

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    cboDisk.Items.Add(drive.Name);
                }
            }
        }

        private void HienThiThuMuc(string path)
        {
            try
            {
                DirectoryInfo folder = new DirectoryInfo(path);

                //Read list before changing interface
                DirectoryInfo[] folders = folder.GetDirectories();
                FileInfo[] files = folder.GetFiles();

                listvFolder.Items.Clear();
                rTxtInfo.Clear();

                foreach (DirectoryInfo subFolder in folders)
                {
                    ListViewItem item = new ListViewItem(subFolder.Name);

                    item.SubItems.Add("Thư mục");
                    item.SubItems.Add("");

                    // Giữ đường dẫn đầy đủ để mở khi nhấp đúp.
                    item.Tag = subFolder.FullName;

                    listvFolder.Items.Add(item);
                }

                foreach (FileInfo file in files)
                {
                    ListViewItem item = new ListViewItem(file.Name);

                    item.SubItems.Add(file.Extension);
                    item.SubItems.Add(file.Length + " bytes");
                    item.Tag = file.FullName;

                    listvFolder.Items.Add(item);
                }

                duongDanHienTai = folder.FullName;
                mTxtFullName.Text = duongDanHienTai;
            }

            catch (IOException ex)
            {
                MessageBox.Show("Không thể mở thư mục: " + ex.Message);
            }

            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Không có quyền truy cập thư mục này.");
            }
        }

        private void cboDisk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDisk.SelectedItem != null)
            {
                HienThiThuMuc(cboDisk.SelectedItem.ToString());
            }
        }

        private void listvFolder_DoubleClick(object sender, EventArgs e)
        {
            if (listvFolder.SelectedItems.Count == 0) return;

            string path = listvFolder.SelectedItems[0].Tag.ToString();

            if (Directory.Exists(path))
            {
                HienThiThuMuc(path);
            }
        }

        private void listvFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            rTxtInfo.Clear();

            if (listvFolder.SelectedItems.Count == 0)
            {
                return;
            }

            string path = listvFolder.SelectedItems[0].Tag.ToString();

            if (Directory.Exists(path))
            {
                return;
            }

            try
            {
                string extension = Path.GetExtension(path).ToLowerInvariant();

                switch (extension)
                {
                    case ".txt":
                    case ".csv":
                    case ".json":
                    case ".xml":
                    case ".cs":
                    case ".html":
                    case ".css":
                    case ".js":
                    case ".md":
                    case ".log":
                        break;
                    default:
                        rTxtInfo.Text = "Chưa hỗ trợ xem trước định dạng file này.";
                        return;
                }

                FileInfo file = new FileInfo(path);

                //Limitting preview to prevent large files

                if (file.Length > 2 * 1024 * 1024)
                {
                    rTxtInfo.Text = "File lớn hơn 2 MB, không hiển thị xem trước.";
                    return;
                }

                using (StreamReader reader = new StreamReader(path))
                {
                    rTxtInfo.Text = reader.ReadToEnd();
                }
            }

            catch (IOException ex)
            {
                MessageBox.Show("Không thể đọc file: " + ex.Message);
            }

            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Không có quyền đọc file này.");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(duongDanHienTai))
            {
                return;
            }

            try
            {
                DirectoryInfo parent = Directory.GetParent(duongDanHienTai);

                if (parent != null)
                {
                    HienThiThuMuc(parent.FullName);
                }
            }

            catch (IOException ex)
            {
                MessageBox.Show("Không thể mở thư mục cha: " + ex.Message);
            }

            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Không có quyền mở thư mục cha.");
            }
        }
    }
}
