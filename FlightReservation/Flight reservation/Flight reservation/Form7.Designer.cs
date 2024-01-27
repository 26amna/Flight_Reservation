namespace Flight_reservation
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(124, 109);
            label1.Name = "label1";
            label1.Size = new Size(147, 36);
            label1.TabIndex = 0;
            label1.Text = "Login as a/an:";
            label1.Click += label1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(124, 192);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(92, 40);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Admin";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.Location = new Point(124, 272);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(127, 40);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Customer";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(955, 642);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}