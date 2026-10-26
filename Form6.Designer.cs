namespace _25520840_Lab2
{
    partial class Form6
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
            label1 = new Label();
            txtAddName = new TextBox();
            btnAdd = new Button();
            btnExit = new Button();
            btnRandom = new Button();
            btnDelete = new Button();
            txtRandRes = new TextBox();
            label2 = new Label();
            lvFoodList = new ListView();
            clmMaMon = new ColumnHeader();
            clmTenMon = new ColumnHeader();
            clmNguoiDongGop = new ColumnHeader();
            label3 = new Label();
            btnAddPicture = new Button();
            btnAddName = new Button();
            txtAddFood = new TextBox();
            label4 = new Label();
            label5 = new Label();
            pcbFoodPic = new PictureBox();
            txtPictureLink = new TextBox();
            cboName = new ComboBox();
            txtResultName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbFoodPic).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 45);
            label1.Name = "label1";
            label1.Size = new Size(164, 19);
            label1.TabIndex = 0;
            label1.Text = "Nhập tên người đóng góp";
            // 
            // txtAddName
            // 
            txtAddName.Location = new Point(206, 45);
            txtAddName.MaxLength = 100;
            txtAddName.Name = "txtAddName";
            txtAddName.PlaceholderText = "Nguyễn Văn A";
            txtAddName.Size = new Size(235, 23);
            txtAddName.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(186, 164);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(81, 51);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm món ăn";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(723, 9);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(65, 30);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(360, 164);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(81, 51);
            btnRandom.TabIndex = 6;
            btnRandom.Text = "Tìm món ăn";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(273, 164);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(81, 51);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa món đã chọn";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtRandRes
            // 
            txtRandRes.BackColor = SystemColors.ControlLightLight;
            txtRandRes.Location = new Point(12, 250);
            txtRandRes.Name = "txtRandRes";
            txtRandRes.PlaceholderText = "Món random";
            txtRandRes.ReadOnly = true;
            txtRandRes.Size = new Size(217, 23);
            txtRandRes.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(150, 228);
            label2.Name = "label2";
            label2.Size = new Size(146, 19);
            label2.TabIndex = 7;
            label2.Text = "Món ăn hôm nay ăn là:";
            // 
            // lvFoodList
            // 
            lvFoodList.Columns.AddRange(new ColumnHeader[] { clmMaMon, clmTenMon, clmNguoiDongGop });
            lvFoodList.FullRowSelect = true;
            lvFoodList.GridLines = true;
            lvFoodList.Location = new Point(447, 45);
            lvFoodList.MultiSelect = false;
            lvFoodList.Name = "lvFoodList";
            lvFoodList.Size = new Size(341, 393);
            lvFoodList.TabIndex = 8;
            lvFoodList.UseCompatibleStateImageBehavior = false;
            lvFoodList.View = View.Details;
            // 
            // clmMaMon
            // 
            clmMaMon.Text = "Mã Món";
            // 
            // clmTenMon
            // 
            clmTenMon.Text = "Tên món";
            clmTenMon.Width = 140;
            // 
            // clmNguoiDongGop
            // 
            clmNguoiDongGop.Text = "Người đóng góp";
            clmNguoiDongGop.Width = 140;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(300, 9);
            label3.Name = "label3";
            label3.Size = new Size(231, 29);
            label3.TabIndex = 9;
            label3.Text = "TRƯA NAY ĂN GÌ?";
            // 
            // btnAddPicture
            // 
            btnAddPicture.Location = new Point(99, 164);
            btnAddPicture.Name = "btnAddPicture";
            btnAddPicture.Size = new Size(81, 51);
            btnAddPicture.TabIndex = 4;
            btnAddPicture.Text = "Thêm hình ảnh món ăn";
            btnAddPicture.UseVisualStyleBackColor = true;
            btnAddPicture.Click += btnAddPicture_Click;
            // 
            // btnAddName
            // 
            btnAddName.Location = new Point(12, 164);
            btnAddName.Name = "btnAddName";
            btnAddName.Size = new Size(81, 51);
            btnAddName.TabIndex = 1;
            btnAddName.Text = "Thêm người đóng góp";
            btnAddName.UseVisualStyleBackColor = true;
            btnAddName.Click += btnAddName_Click;
            // 
            // txtAddFood
            // 
            txtAddFood.Location = new Point(206, 103);
            txtAddFood.MaxLength = 100;
            txtAddFood.Name = "txtAddFood";
            txtAddFood.PlaceholderText = "Ăn gì cũng được";
            txtAddFood.Size = new Size(235, 23);
            txtAddFood.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 103);
            label4.Name = "label4";
            label4.Size = new Size(91, 19);
            label4.TabIndex = 12;
            label4.Text = "Nhập món ăn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 74);
            label5.Name = "label5";
            label5.Size = new Size(184, 19);
            label5.TabIndex = 14;
            label5.Text = "(Hoặc) chọn người đóng góp";
            // 
            // pcbFoodPic
            // 
            pcbFoodPic.BackColor = SystemColors.ButtonHighlight;
            pcbFoodPic.BorderStyle = BorderStyle.FixedSingle;
            pcbFoodPic.Location = new Point(12, 279);
            pcbFoodPic.Name = "pcbFoodPic";
            pcbFoodPic.Size = new Size(429, 159);
            pcbFoodPic.SizeMode = PictureBoxSizeMode.Zoom;
            pcbFoodPic.TabIndex = 16;
            pcbFoodPic.TabStop = false;
            // 
            // txtPictureLink
            // 
            txtPictureLink.BackColor = SystemColors.ControlLightLight;
            txtPictureLink.Location = new Point(12, 135);
            txtPictureLink.Name = "txtPictureLink";
            txtPictureLink.PlaceholderText = "Đường dẫn của ảnh món ăn";
            txtPictureLink.ReadOnly = true;
            txtPictureLink.Size = new Size(429, 23);
            txtPictureLink.TabIndex = 18;
            // 
            // cboName
            // 
            cboName.DropDownStyle = ComboBoxStyle.DropDownList;
            cboName.FormattingEnabled = true;
            cboName.Location = new Point(206, 74);
            cboName.Name = "cboName";
            cboName.Size = new Size(235, 23);
            cboName.TabIndex = 2;
            // 
            // txtResultName
            // 
            txtResultName.BackColor = SystemColors.ControlLightLight;
            txtResultName.Location = new Point(235, 250);
            txtResultName.Name = "txtResultName";
            txtResultName.PlaceholderText = "Người đã đóng góp cho món";
            txtResultName.ReadOnly = true;
            txtResultName.Size = new Size(206, 23);
            txtResultName.TabIndex = 20;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultName);
            Controls.Add(cboName);
            Controls.Add(txtPictureLink);
            Controls.Add(pcbFoodPic);
            Controls.Add(label5);
            Controls.Add(txtAddFood);
            Controls.Add(label4);
            Controls.Add(btnAddName);
            Controls.Add(btnAddPicture);
            Controls.Add(label3);
            Controls.Add(lvFoodList);
            Controls.Add(label2);
            Controls.Add(txtRandRes);
            Controls.Add(btnDelete);
            Controls.Add(btnRandom);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(txtAddName);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Trưa nay ăn gì?";
            ((System.ComponentModel.ISupportInitialize)pcbFoodPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAddName;
        private Button btnAdd;
        private Button btnExit;
        private Button btnRandom;
        private Button btnDelete;
        private TextBox txtRandRes;
        private Label label2;
        private ListView lvFoodList;
        private Label label3;
        private Button btnAddPicture;
        private Button btnAddName;
        private TextBox txtAddFood;
        private Label label4;
        private Label label5;
        private PictureBox pcbFoodPic;
        private TextBox txtPictureLink;
        private ComboBox cboName;
        private TextBox txtResultName;
        private ColumnHeader clmMaMon;
        private ColumnHeader clmTenMon;
        private ColumnHeader clmNguoiDongGop;
    }
}