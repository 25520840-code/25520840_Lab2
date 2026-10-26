namespace _25520840_Lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_Input = new Button();
            rTxt_Input = new RichTextBox();
            rTxt_Output = new RichTextBox();
            btn_Transfer = new Button();
            btn_Download = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 9);
            label1.Name = "label1";
            label1.Size = new Size(601, 28);
            label1.TabIndex = 0;
            label1.Text = "CÔNG CỤ CHUYỂN ĐỔI CHỮ HOA TRONG FILE .TXT";
            // 
            // btn_Input
            // 
            btn_Input.Location = new Point(350, 40);
            btn_Input.Name = "btn_Input";
            btn_Input.Size = new Size(94, 29);
            btn_Input.TabIndex = 1;
            btn_Input.Text = "Input file";
            btn_Input.UseVisualStyleBackColor = true;
            btn_Input.Click += btn_Input_Click;
            // 
            // rTxt_Input
            // 
            rTxt_Input.Location = new Point(12, 75);
            rTxt_Input.Name = "rTxt_Input";
            rTxt_Input.Size = new Size(776, 120);
            rTxt_Input.TabIndex = 2;
            rTxt_Input.Text = "";
            // 
            // rTxt_Output
            // 
            rTxt_Output.Location = new Point(12, 231);
            rTxt_Output.Name = "rTxt_Output";
            rTxt_Output.Size = new Size(776, 169);
            rTxt_Output.TabIndex = 4;
            rTxt_Output.Text = "";
            // 
            // btn_Transfer
            // 
            btn_Transfer.Location = new Point(350, 196);
            btn_Transfer.Name = "btn_Transfer";
            btn_Transfer.Size = new Size(94, 29);
            btn_Transfer.TabIndex = 3;
            btn_Transfer.Text = "Transfer";
            btn_Transfer.UseVisualStyleBackColor = true;
            btn_Transfer.Click += btn_Transfer_Click;
            // 
            // btn_Download
            // 
            btn_Download.Location = new Point(694, 409);
            btn_Download.Name = "btn_Download";
            btn_Download.Size = new Size(94, 29);
            btn_Download.TabIndex = 5;
            btn_Download.Text = "Download";
            btn_Download.UseVisualStyleBackColor = true;
            btn_Download.Click += btn_Download_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Download);
            Controls.Add(rTxt_Output);
            Controls.Add(btn_Transfer);
            Controls.Add(rTxt_Input);
            Controls.Add(btn_Input);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Input;
        private RichTextBox rTxt_Input;
        private RichTextBox rTxt_Output;
        private Button btn_Transfer;
        private Button btn_Download;
    }
}
