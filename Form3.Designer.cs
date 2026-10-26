namespace _25520840_Lab2
{
    partial class Form3
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
            rTxt_Input = new RichTextBox();
            btnCalc = new Button();
            btnDownload = new Button();
            rTxt_Output = new RichTextBox();
            btnInput = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 9);
            label1.Name = "label1";
            label1.Size = new Size(516, 36);
            label1.TabIndex = 0;
            label1.Text = "CÔNG CỤ TÍNH ĐA THỨC TỪ FILE";
            // 
            // rTxt_Input
            // 
            rTxt_Input.Location = new Point(12, 87);
            rTxt_Input.Name = "rTxt_Input";
            rTxt_Input.Size = new Size(776, 120);
            rTxt_Input.TabIndex = 1;
            rTxt_Input.Text = "";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(308, 211);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(184, 29);
            btnCalc.TabIndex = 3;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(604, 409);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(184, 29);
            btnDownload.TabIndex = 4;
            btnDownload.Text = "Download results";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // rTxt_Output
            // 
            rTxt_Output.Location = new Point(12, 246);
            rTxt_Output.Name = "rTxt_Output";
            rTxt_Output.Size = new Size(776, 157);
            rTxt_Output.TabIndex = 5;
            rTxt_Output.Text = "";
            // 
            // btnInput
            // 
            btnInput.Location = new Point(308, 48);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(184, 29);
            btnInput.TabIndex = 6;
            btnInput.Text = "Input files with equation";
            btnInput.UseVisualStyleBackColor = true;
            btnInput.Click += btnInput_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInput);
            Controls.Add(rTxt_Output);
            Controls.Add(btnDownload);
            Controls.Add(btnCalc);
            Controls.Add(rTxt_Input);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox rTxt_Input;
        private Button btnCalc;
        private Button btnDownload;
        private RichTextBox rTxt_Output;
        private Button btnInput;
    }
}