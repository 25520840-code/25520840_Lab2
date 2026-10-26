namespace _25520840_Lab2
{
    partial class Form2
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
            btn_Input = new Button();
            rTxt_Input = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtFileName = new TextBox();
            txtSizeInBytes = new TextBox();
            txtPath = new TextBox();
            txtCountLine = new TextBox();
            txtCountWord = new TextBox();
            txtCountCharacter = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(158, 9);
            label1.Name = "label1";
            label1.Size = new Size(488, 28);
            label1.TabIndex = 0;
            label1.Text = "CÔNG CỤ THỂ HIỆN METADATA CỦA FILE";
            // 
            // btn_Input
            // 
            btn_Input.Location = new Point(497, 75);
            btn_Input.Name = "btn_Input";
            btn_Input.Size = new Size(291, 57);
            btn_Input.TabIndex = 1;
            btn_Input.Text = "Input file";
            btn_Input.UseVisualStyleBackColor = true;
            btn_Input.Click += btn_Input_Click;
            // 
            // rTxt_Input
            // 
            rTxt_Input.Location = new Point(12, 75);
            rTxt_Input.Name = "rTxt_Input";
            rTxt_Input.Size = new Size(479, 363);
            rTxt_Input.TabIndex = 2;
            rTxt_Input.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(497, 148);
            label2.Name = "label2";
            label2.Size = new Size(291, 21);
            label2.TabIndex = 3;
            label2.Text = "File metadata / File Information:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(497, 193);
            label3.Name = "label3";
            label3.Size = new Size(88, 18);
            label3.TabIndex = 4;
            label3.Text = "File Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(497, 239);
            label4.Name = "label4";
            label4.Size = new Size(108, 18);
            label4.TabIndex = 5;
            label4.Text = "Size in bytes:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(497, 283);
            label5.Name = "label5";
            label5.Size = new Size(78, 18);
            label5.TabIndex = 6;
            label5.Text = "Full path:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(497, 328);
            label6.Name = "label6";
            label6.Size = new Size(90, 18);
            label6.TabIndex = 7;
            label6.Text = "Line count:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(497, 375);
            label7.Name = "label7";
            label7.Size = new Size(98, 18);
            label7.TabIndex = 8;
            label7.Text = "Word count:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonHighlight;
            label8.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(497, 420);
            label8.Name = "label8";
            label8.Size = new Size(132, 18);
            label8.TabIndex = 9;
            label8.Text = "Character count:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonHighlight;
            label9.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(614, 193);
            label9.Name = "label9";
            label9.Size = new Size(0, 18);
            label9.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonHighlight;
            label10.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(646, 239);
            label10.Name = "label10";
            label10.Size = new Size(0, 18);
            label10.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ButtonHighlight;
            label11.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(614, 193);
            label11.Name = "label11";
            label11.Size = new Size(0, 18);
            label11.TabIndex = 12;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(591, 189);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(197, 27);
            txtFileName.TabIndex = 13;
            // 
            // txtSizeInBytes
            // 
            txtSizeInBytes.Location = new Point(611, 235);
            txtSizeInBytes.Name = "txtSizeInBytes";
            txtSizeInBytes.Size = new Size(177, 27);
            txtSizeInBytes.TabIndex = 14;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(581, 279);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(207, 27);
            txtPath.TabIndex = 15;
            // 
            // txtCountLine
            // 
            txtCountLine.Location = new Point(593, 324);
            txtCountLine.Name = "txtCountLine";
            txtCountLine.Size = new Size(195, 27);
            txtCountLine.TabIndex = 16;
            // 
            // txtCountWord
            // 
            txtCountWord.Location = new Point(601, 371);
            txtCountWord.Name = "txtCountWord";
            txtCountWord.Size = new Size(187, 27);
            txtCountWord.TabIndex = 17;
            // 
            // txtCountCharacter
            // 
            txtCountCharacter.Location = new Point(635, 416);
            txtCountCharacter.Name = "txtCountCharacter";
            txtCountCharacter.Size = new Size(153, 27);
            txtCountCharacter.TabIndex = 18;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCountCharacter);
            Controls.Add(txtCountWord);
            Controls.Add(txtCountLine);
            Controls.Add(txtPath);
            Controls.Add(txtSizeInBytes);
            Controls.Add(txtFileName);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rTxt_Input);
            Controls.Add(btn_Input);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Input;
        private RichTextBox rTxt_Input;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtFileName;
        private TextBox txtSizeInBytes;
        private TextBox txtPath;
        private TextBox txtCountLine;
        private TextBox txtCountWord;
        private TextBox txtCountCharacter;
    }
}