namespace WinFormsApp3
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
            btnBMI = new Button();
            IblHeight = new Label();
            IblWeight = new Label();
            lblOutput = new Label();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            SuspendLayout();
            // 
            // btnBMI
            // 
            btnBMI.Location = new Point(195, 11);
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(70, 52);
            btnBMI.TabIndex = 0;
            btnBMI.Text = "計算 BMI";
            btnBMI.UseVisualStyleBackColor = true;
            btnBMI.Click += btnBMI_Click;
            // 
            // IblHeight
            // 
            IblHeight.AutoSize = true;
            IblHeight.Location = new Point(20, 11);
            IblHeight.Name = "IblHeight";
            IblHeight.Size = new Size(79, 15);
            IblHeight.TabIndex = 1;
            IblHeight.Text = "身高（公分）";
            // 
            // IblWeight
            // 
            IblWeight.Location = new Point(20, 48);
            IblWeight.Name = "IblWeight";
            IblWeight.Size = new Size(79, 15);
            IblWeight.TabIndex = 2;
            IblWeight.Text = "體重（公斤）";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(20, 77);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 15);
            lblOutput.TabIndex = 3;
            lblOutput.Click += label3_Click;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(97, 8);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(92, 23);
            txtHeight.TabIndex = 4;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(97, 45);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(92, 23);
            txtWeight.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 111);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(lblOutput);
            Controls.Add(IblWeight);
            Controls.Add(IblHeight);
            Controls.Add(btnBMI);
            Name = "Form1";
            Text = "BMI 計算機";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBMI;
        private Label IblHeight;
        private Label IblWeight;
        private Label lblOutput;
        private TextBox txtHeight;
        private TextBox txtWeight;
    }
}
