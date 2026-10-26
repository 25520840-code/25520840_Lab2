using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _25520840_Lab2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Input_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Text files (*.txt)|*.txt";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                string path = dialog.FileName;

                //Get info about the file
                FileInfo info = new FileInfo(path);

                txtFileName.Text = info.Name;
                txtSizeInBytes.Text = info.Length + " bytes";
                txtPath.Text = info.FullName;

                //Read and display content
                string content;

                using (StreamReader reader = new StreamReader(path))
                {
                    content= reader.ReadToEnd();
                }

                rTxt_Input.Text = content;

                //Count characters and words
                txtCountCharacter.Text = content.Length.ToString();

                string[] words = content.Split(
                    new char[] { ' ', '\t', '\r', '\n' },
                    StringSplitOptions.RemoveEmptyEntries);

                txtCountWord.Text = words.Length.ToString();

                //Count lines
                int lineCount = 0;

                using (StringReader reader = new StringReader(content))
                {
                    while (reader.ReadLine () != null)
                    {
                        lineCount++;
                    }
                }

                txtCountLine.Text = lineCount.ToString();
            }
        }
    }
}
