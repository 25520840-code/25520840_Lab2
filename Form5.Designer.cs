namespace _25520840_Lab2
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtHoTen = new TextBox();
            label2 = new Label();
            cboPhim = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cboPhong = new ComboBox();
            label5 = new Label();
            btnMuaVe = new Button();
            txtKetQua = new TextBox();
            label6 = new Label();
            tlbGhe = new TableLayoutPanel();
            C5 = new CheckBox();
            C4 = new CheckBox();
            C3 = new CheckBox();
            C2 = new CheckBox();
            C1 = new CheckBox();
            B5 = new CheckBox();
            B4 = new CheckBox();
            B3 = new CheckBox();
            B2 = new CheckBox();
            B1 = new CheckBox();
            A5 = new CheckBox();
            A4 = new CheckBox();
            A3 = new CheckBox();
            A2 = new CheckBox();
            A1 = new CheckBox();
            btnAddFilm = new Button();
            btnAddFilmInfo = new Button();
            label7 = new Label();
            txtNewFilmName = new TextBox();
            label8 = new Label();
            label9 = new Label();
            numTicketPrice = new NumericUpDown();
            clbFilmRooms = new CheckedListBox();
            btnSaveFilms = new Button();
            btnExportRevenue = new Button();
            pbExport = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tlbGhe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTicketPrice).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(7, 12, 70);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SVN-Megante", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(183, -5);
            label1.Name = "label1";
            label1.Size = new Size(501, 64);
            label1.TabIndex = 4;
            label1.Text = "OEC Movie Theatre";
            // 
            // txtHoTen
            // 
            txtHoTen.Cursor = Cursors.No;
            txtHoTen.Location = new Point(230, 84);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(353, 23);
            txtHoTen.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SVN-Megante", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(312, 45);
            label2.Name = "label2";
            label2.Size = new Size(163, 36);
            label2.TabIndex = 6;
            label2.Text = "Your name:";
            // 
            // cboPhim
            // 
            cboPhim.Cursor = Cursors.No;
            cboPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhim.FormattingEnabled = true;
            cboPhim.Location = new Point(230, 151);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(353, 23);
            cboPhim.TabIndex = 7;
            cboPhim.SelectedIndexChanged += cboPhim_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SVN-Megante", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(355, 112);
            label3.Name = "label3";
            label3.Size = new Size(68, 36);
            label3.TabIndex = 8;
            label3.Text = "Film";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SVN-Megante", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(312, 178);
            label4.Name = "label4";
            label4.Size = new Size(152, 36);
            label4.TabIndex = 10;
            label4.Text = "Film Room";
            // 
            // cboPhong
            // 
            cboPhong.Cursor = Cursors.No;
            cboPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhong.FormattingEnabled = true;
            cboPhong.Location = new Point(230, 217);
            cboPhong.Name = "cboPhong";
            cboPhong.Size = new Size(353, 23);
            cboPhong.TabIndex = 9;
            cboPhong.SelectedIndexChanged += cboPhong_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SVN-Megante", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(337, 243);
            label5.Name = "label5";
            label5.Size = new Size(86, 36);
            label5.TabIndex = 12;
            label5.Text = "Seats";
            // 
            // btnMuaVe
            // 
            btnMuaVe.Font = new Font("SVN-Megante", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMuaVe.Location = new Point(230, 404);
            btnMuaVe.Name = "btnMuaVe";
            btnMuaVe.Size = new Size(353, 34);
            btnMuaVe.TabIndex = 13;
            btnMuaVe.Text = "Confirm Buying";
            btnMuaVe.UseVisualStyleBackColor = true;
            btnMuaVe.Click += btnMuaVe_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.Cursor = Cursors.No;
            txtKetQua.Font = new Font("SVN-Megante", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKetQua.Location = new Point(600, 84);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.ScrollBars = ScrollBars.Vertical;
            txtKetQua.Size = new Size(188, 354);
            txtKetQua.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SVN-Megante", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(606, 45);
            label6.Name = "label6";
            label6.Size = new Size(182, 36);
            label6.TabIndex = 15;
            label6.Text = "Your Tickets:";
            // 
            // tlbGhe
            // 
            tlbGhe.BackColor = SystemColors.Window;
            tlbGhe.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial;
            tlbGhe.ColumnCount = 5;
            tlbGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            tlbGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            tlbGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            tlbGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            tlbGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            tlbGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            tlbGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            tlbGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            tlbGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            tlbGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            tlbGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            tlbGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            tlbGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            tlbGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            tlbGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            tlbGhe.Controls.Add(C5, 4, 2);
            tlbGhe.Controls.Add(C4, 3, 2);
            tlbGhe.Controls.Add(C3, 2, 2);
            tlbGhe.Controls.Add(C2, 1, 2);
            tlbGhe.Controls.Add(C1, 0, 2);
            tlbGhe.Controls.Add(B5, 4, 1);
            tlbGhe.Controls.Add(B4, 3, 1);
            tlbGhe.Controls.Add(B3, 2, 1);
            tlbGhe.Controls.Add(B2, 1, 1);
            tlbGhe.Controls.Add(B1, 0, 1);
            tlbGhe.Controls.Add(A5, 4, 0);
            tlbGhe.Controls.Add(A4, 3, 0);
            tlbGhe.Controls.Add(A3, 2, 0);
            tlbGhe.Controls.Add(A2, 1, 0);
            tlbGhe.Controls.Add(A1, 0, 0);
            tlbGhe.Location = new Point(230, 282);
            tlbGhe.Name = "tlbGhe";
            tlbGhe.RowCount = 3;
            tlbGhe.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlbGhe.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlbGhe.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlbGhe.Size = new Size(353, 116);
            tlbGhe.TabIndex = 16;
            // 
            // C5
            // 
            C5.Appearance = Appearance.Button;
            C5.Dock = DockStyle.Fill;
            C5.Font = new Font("SVN-Megante", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            C5.Location = new Point(286, 80);
            C5.Name = "C5";
            C5.Size = new Size(61, 30);
            C5.TabIndex = 14;
            C5.Text = "C5";
            C5.TextAlign = ContentAlignment.TopCenter;
            C5.UseVisualStyleBackColor = true;
            // 
            // C4
            // 
            C4.Appearance = Appearance.Button;
            C4.Dock = DockStyle.Fill;
            C4.Font = new Font("SVN-Megante", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            C4.Location = new Point(216, 80);
            C4.Name = "C4";
            C4.Size = new Size(61, 30);
            C4.TabIndex = 13;
            C4.Text = "C4";
            C4.TextAlign = ContentAlignment.TopCenter;
            C4.UseVisualStyleBackColor = true;
            // 
            // C3
            // 
            C3.Appearance = Appearance.Button;
            C3.Dock = DockStyle.Fill;
            C3.Font = new Font("SVN-Megante", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            C3.Location = new Point(146, 80);
            C3.Name = "C3";
            C3.Size = new Size(61, 30);
            C3.TabIndex = 12;
            C3.Text = "C3";
            C3.TextAlign = ContentAlignment.TopCenter;
            C3.UseVisualStyleBackColor = true;
            // 
            // C2
            // 
            C2.Appearance = Appearance.Button;
            C2.Dock = DockStyle.Fill;
            C2.Font = new Font("SVN-Megante", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            C2.Location = new Point(76, 80);
            C2.Name = "C2";
            C2.Size = new Size(61, 30);
            C2.TabIndex = 11;
            C2.Text = "C2";
            C2.TextAlign = ContentAlignment.TopCenter;
            C2.UseVisualStyleBackColor = true;
            // 
            // C1
            // 
            C1.Appearance = Appearance.Button;
            C1.Dock = DockStyle.Fill;
            C1.Font = new Font("SVN-Megante", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            C1.Location = new Point(6, 80);
            C1.Name = "C1";
            C1.Size = new Size(61, 30);
            C1.TabIndex = 10;
            C1.Text = "C1";
            C1.TextAlign = ContentAlignment.TopCenter;
            C1.UseVisualStyleBackColor = true;
            // 
            // B5
            // 
            B5.Appearance = Appearance.Button;
            B5.Dock = DockStyle.Fill;
            B5.Font = new Font("SVN-Megante", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B5.Location = new Point(286, 43);
            B5.Name = "B5";
            B5.Size = new Size(61, 28);
            B5.TabIndex = 9;
            B5.Text = "B5";
            B5.TextAlign = ContentAlignment.TopCenter;
            B5.UseVisualStyleBackColor = true;
            // 
            // B4
            // 
            B4.Appearance = Appearance.Button;
            B4.Dock = DockStyle.Fill;
            B4.Font = new Font("SVN-Megante", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B4.Location = new Point(216, 43);
            B4.Name = "B4";
            B4.Size = new Size(61, 28);
            B4.TabIndex = 8;
            B4.Text = "B4";
            B4.TextAlign = ContentAlignment.TopCenter;
            B4.UseVisualStyleBackColor = true;
            // 
            // B3
            // 
            B3.Appearance = Appearance.Button;
            B3.Dock = DockStyle.Fill;
            B3.Font = new Font("SVN-Megante", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B3.Location = new Point(146, 43);
            B3.Name = "B3";
            B3.Size = new Size(61, 28);
            B3.TabIndex = 7;
            B3.Text = "B3";
            B3.TextAlign = ContentAlignment.TopCenter;
            B3.UseVisualStyleBackColor = true;
            // 
            // B2
            // 
            B2.Appearance = Appearance.Button;
            B2.Dock = DockStyle.Fill;
            B2.Font = new Font("SVN-Megante", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B2.Location = new Point(76, 43);
            B2.Name = "B2";
            B2.Size = new Size(61, 28);
            B2.TabIndex = 6;
            B2.Text = "B2";
            B2.TextAlign = ContentAlignment.TopCenter;
            B2.UseVisualStyleBackColor = true;
            // 
            // B1
            // 
            B1.Appearance = Appearance.Button;
            B1.Dock = DockStyle.Fill;
            B1.Font = new Font("SVN-Megante", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B1.Location = new Point(6, 43);
            B1.Name = "B1";
            B1.Size = new Size(61, 28);
            B1.TabIndex = 5;
            B1.Text = "B1";
            B1.TextAlign = ContentAlignment.TopCenter;
            B1.UseVisualStyleBackColor = true;
            // 
            // A5
            // 
            A5.Appearance = Appearance.Button;
            A5.Dock = DockStyle.Fill;
            A5.Font = new Font("SVN-Megante", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            A5.Location = new Point(286, 6);
            A5.Name = "A5";
            A5.Size = new Size(61, 28);
            A5.TabIndex = 4;
            A5.Text = "A5";
            A5.TextAlign = ContentAlignment.TopCenter;
            A5.UseVisualStyleBackColor = true;
            // 
            // A4
            // 
            A4.Appearance = Appearance.Button;
            A4.Dock = DockStyle.Fill;
            A4.Font = new Font("SVN-Megante", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            A4.Location = new Point(216, 6);
            A4.Name = "A4";
            A4.Size = new Size(61, 28);
            A4.TabIndex = 3;
            A4.Text = "A4";
            A4.TextAlign = ContentAlignment.TopCenter;
            A4.UseVisualStyleBackColor = true;
            // 
            // A3
            // 
            A3.Appearance = Appearance.Button;
            A3.Dock = DockStyle.Fill;
            A3.Font = new Font("SVN-Megante", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            A3.Location = new Point(146, 6);
            A3.Name = "A3";
            A3.Size = new Size(61, 28);
            A3.TabIndex = 2;
            A3.Text = "A3";
            A3.TextAlign = ContentAlignment.TopCenter;
            A3.UseVisualStyleBackColor = true;
            // 
            // A2
            // 
            A2.Appearance = Appearance.Button;
            A2.Dock = DockStyle.Fill;
            A2.Font = new Font("SVN-Megante", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            A2.Location = new Point(76, 6);
            A2.Name = "A2";
            A2.Size = new Size(61, 28);
            A2.TabIndex = 1;
            A2.Text = "A2";
            A2.TextAlign = ContentAlignment.TopCenter;
            A2.UseCompatibleTextRendering = true;
            A2.UseVisualStyleBackColor = true;
            // 
            // A1
            // 
            A1.Appearance = Appearance.Button;
            A1.Dock = DockStyle.Fill;
            A1.Font = new Font("SVN-Megante", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            A1.Location = new Point(6, 6);
            A1.Name = "A1";
            A1.Size = new Size(61, 28);
            A1.TabIndex = 0;
            A1.Text = "A1";
            A1.TextAlign = ContentAlignment.TopCenter;
            A1.UseVisualStyleBackColor = true;
            // 
            // btnAddFilm
            // 
            btnAddFilm.Location = new Point(7, 385);
            btnAddFilm.Name = "btnAddFilm";
            btnAddFilm.Size = new Size(106, 23);
            btnAddFilm.TabIndex = 17;
            btnAddFilm.Text = "Read List";
            btnAddFilm.UseVisualStyleBackColor = true;
            btnAddFilm.Click += btnAddFilm_Click;
            // 
            // btnAddFilmInfo
            // 
            btnAddFilmInfo.Location = new Point(7, 356);
            btnAddFilmInfo.Name = "btnAddFilmInfo";
            btnAddFilmInfo.Size = new Size(106, 23);
            btnAddFilmInfo.TabIndex = 18;
            btnAddFilmInfo.Text = "Add Film Info";
            btnAddFilmInfo.UseVisualStyleBackColor = true;
            btnAddFilmInfo.Click += btnAddFilmInfo_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(7, 157);
            label7.Name = "label7";
            label7.Size = new Size(99, 19);
            label7.TabIndex = 19;
            label7.Text = "Film name:";
            // 
            // txtNewFilmName
            // 
            txtNewFilmName.Location = new Point(7, 178);
            txtNewFilmName.Name = "txtNewFilmName";
            txtNewFilmName.Size = new Size(217, 23);
            txtNewFilmName.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(7, 213);
            label8.Name = "label8";
            label8.Size = new Size(146, 19);
            label8.TabIndex = 21;
            label8.Text = "Film ticket price:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(7, 267);
            label9.Name = "label9";
            label9.Size = new Size(104, 19);
            label9.TabIndex = 23;
            label9.Text = "Film rooms:";
            // 
            // numTicketPrice
            // 
            numTicketPrice.Location = new Point(7, 241);
            numTicketPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numTicketPrice.Minimum = new decimal(new int[] { 10000, 0, 0, 0 });
            numTicketPrice.Name = "numTicketPrice";
            numTicketPrice.Size = new Size(217, 23);
            numTicketPrice.TabIndex = 25;
            numTicketPrice.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // clbFilmRooms
            // 
            clbFilmRooms.CheckOnClick = true;
            clbFilmRooms.FormattingEnabled = true;
            clbFilmRooms.Items.AddRange(new object[] { "1", "2", "3" });
            clbFilmRooms.Location = new Point(7, 289);
            clbFilmRooms.Name = "clbFilmRooms";
            clbFilmRooms.Size = new Size(217, 58);
            clbFilmRooms.TabIndex = 27;
            // 
            // btnSaveFilms
            // 
            btnSaveFilms.Location = new Point(119, 356);
            btnSaveFilms.Name = "btnSaveFilms";
            btnSaveFilms.Size = new Size(105, 23);
            btnSaveFilms.TabIndex = 28;
            btnSaveFilms.Text = "Save Film List";
            btnSaveFilms.UseVisualStyleBackColor = true;
            btnSaveFilms.Click += btnSaveFilms_Click;
            // 
            // btnExportRevenue
            // 
            btnExportRevenue.Location = new Point(118, 385);
            btnExportRevenue.Name = "btnExportRevenue";
            btnExportRevenue.Size = new Size(106, 23);
            btnExportRevenue.TabIndex = 29;
            btnExportRevenue.Text = "Output List";
            btnExportRevenue.UseVisualStyleBackColor = true;
            btnExportRevenue.Click += btnExportRevenue_Click;
            // 
            // pbExport
            // 
            pbExport.Location = new Point(7, 415);
            pbExport.Name = "pbExport";
            pbExport.Size = new Size(217, 23);
            pbExport.TabIndex = 30;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 12, 70);
            ClientSize = new Size(800, 450);
            Controls.Add(pbExport);
            Controls.Add(btnExportRevenue);
            Controls.Add(btnSaveFilms);
            Controls.Add(clbFilmRooms);
            Controls.Add(numTicketPrice);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtNewFilmName);
            Controls.Add(label7);
            Controls.Add(btnAddFilmInfo);
            Controls.Add(btnAddFilm);
            Controls.Add(tlbGhe);
            Controls.Add(label6);
            Controls.Add(txtKetQua);
            Controls.Add(btnMuaVe);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cboPhong);
            Controls.Add(label3);
            Controls.Add(cboPhim);
            Controls.Add(label2);
            Controls.Add(txtHoTen);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tlbGhe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numTicketPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtHoTen;
        private Label label2;
        private ComboBox cboPhim;
        private Label label3;
        private Label label4;
        private ComboBox cboPhong;
        private Label label5;
        private Button btnMuaVe;
        private TextBox txtKetQua;
        private Label label6;
        private TableLayoutPanel tlbGhe;
        private CheckBox A1;
        private CheckBox A3;
        private CheckBox A2;
        private CheckBox C5;
        private CheckBox C4;
        private CheckBox C3;
        private CheckBox C2;
        private CheckBox C1;
        private CheckBox B5;
        private CheckBox B4;
        private CheckBox B3;
        private CheckBox B2;
        private CheckBox B1;
        private CheckBox A5;
        private CheckBox A4;
        private Button btnAddFilm;
        private Button btnAddFilmInfo;
        private Label label7;
        private TextBox txtNewFilmName;
        private Label label8;
        private Label label9;
        private NumericUpDown numTicketPrice;
        private CheckedListBox clbFilmRooms;
        private Button btnSaveFilms;
        private Button btnExportRevenue;
        private ProgressBar pbExport;
    }
}