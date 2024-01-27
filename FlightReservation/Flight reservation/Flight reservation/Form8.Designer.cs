namespace Flight_reservation
{
    partial class Admindo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admindo));
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(127, 112);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(146, 40);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Add Aircraft";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.Location = new Point(127, 180);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(235, 40);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Update Aircraft Model";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox3.Location = new Point(127, 248);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(147, 40);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Delete Flight";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox4.Location = new Point(127, 314);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(155, 40);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Delete Admin";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox5.Location = new Point(127, 380);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(123, 40);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Add Flight";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // Admindo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(969, 667);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Admindo";
            Text = "Admindo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
    }
}