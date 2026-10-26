namespace _25520840_Lab2
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboDisk = new ComboBox();
            mTxtFullName = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnReturn = new Button();
            listvFolder = new ListView();
            clmTen = new ColumnHeader();
            clmLoai = new ColumnHeader();
            clmKichThuoc = new ColumnHeader();
            rTxtInfo = new RichTextBox();
            TxtPage = new TextBox();
            SuspendLayout();
            // 
            // cboDisk
            // 
            cboDisk.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDisk.FormattingEnabled = true;
            cboDisk.Location = new Point(12, 67);
            cboDisk.Name = "cboDisk";
            cboDisk.Size = new Size(121, 23);
            cboDisk.TabIndex = 0;
            cboDisk.SelectedIndexChanged += cboDisk_SelectedIndexChanged;
            // 
            // mTxtFullName
            // 
            mTxtFullName.BackColor = SystemColors.ControlLightLight;
            mTxtFullName.HideSelection = false;
            mTxtFullName.Location = new Point(139, 67);
            mTxtFullName.Name = "mTxtFullName";
            mTxtFullName.ReadOnly = true;
            mTxtFullName.Size = new Size(645, 23);
            mTxtFullName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 9);
            label1.Name = "label1";
            label1.Size = new Size(303, 25);
            label1.TabIndex = 2;
            label1.Text = "CÔNG CỤ KIỂM SOÁT Ổ ĐĨA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 3;
            label2.Text = "Ổ đĩa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(139, 45);
            label3.Name = "label3";
            label3.Size = new Size(117, 18);
            label3.TabIndex = 4;
            label3.Text = "Đường dẫn file";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(12, 415);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(553, 23);
            btnReturn.TabIndex = 5;
            btnReturn.Text = "<<";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // listvFolder
            // 
            listvFolder.BackColor = SystemColors.ControlLightLight;
            listvFolder.Columns.AddRange(new ColumnHeader[] { clmTen, clmLoai, clmKichThuoc });
            listvFolder.FullRowSelect = true;
            listvFolder.Location = new Point(12, 96);
            listvFolder.MultiSelect = false;
            listvFolder.Name = "listvFolder";
            listvFolder.Size = new Size(553, 313);
            listvFolder.TabIndex = 7;
            listvFolder.UseCompatibleStateImageBehavior = false;
            listvFolder.View = View.Details;
            listvFolder.SelectedIndexChanged += listvFolder_SelectedIndexChanged;
            listvFolder.DoubleClick += listvFolder_DoubleClick;
            // 
            // clmTen
            // 
            clmTen.Text = "Tên";
            clmTen.Width = 300;
            // 
            // clmLoai
            // 
            clmLoai.Text = "Loại";
            clmLoai.Width = 120;
            // 
            // clmKichThuoc
            // 
            clmKichThuoc.Text = "Kích thước";
            clmKichThuoc.Width = 120;
            // 
            // rTxtInfo
            // 
            rTxtInfo.BackColor = SystemColors.ControlLightLight;
            rTxtInfo.HideSelection = false;
            rTxtInfo.Location = new Point(571, 96);
            rTxtInfo.Name = "rTxtInfo";
            rTxtInfo.ReadOnly = true;
            rTxtInfo.Size = new Size(213, 313);
            rTxtInfo.TabIndex = 8;
            rTxtInfo.Text = "";
            // 
            // TxtPage
            // 
            TxtPage.BackColor = SystemColors.ControlLightLight;
            TxtPage.HideSelection = false;
            TxtPage.Location = new Point(571, 416);
            TxtPage.Name = "TxtPage";
            TxtPage.ReadOnly = true;
            TxtPage.Size = new Size(213, 23);
            TxtPage.TabIndex = 9;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtPage);
            Controls.Add(rTxtInfo);
            Controls.Add(listvFolder);
            Controls.Add(btnReturn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mTxtFullName);
            Controls.Add(cboDisk);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboDisk;
        private MaskedTextBox mTxtFullName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnReturn;
        private ListView listvFolder;
        private RichTextBox rTxtInfo;
        private TextBox TxtPage;
        private ColumnHeader clmTen;
        private ColumnHeader clmLoai;
        private ColumnHeader clmKichThuoc;
    }
}