namespace WinFormsApp2
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
            button1 = new Button();
            button2 = new Button();
            lblOutput = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 155);
            button1.Name = "button1";
            button1.Size = new Size(90, 40);
            button1.TabIndex = 0;
            button1.Text = "增加";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(110, 155);
            button2.Name = "button2";
            button2.Size = new Size(90, 40);
            button2.TabIndex = 1;
            button2.Text = "歸零";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Microsoft JhengHei UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblOutput.Location = new Point(32, 20);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(109, 122);
            lblOutput.TabIndex = 2;
            lblOutput.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(208, 211);
            Controls.Add(lblOutput);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "計數 器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label lblOutput;
    }
}
