namespace Flight_reservation
{
    partial class Customersdo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customersdo));
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(141, 151);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(178, 40);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Show All Flights";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(141, 258);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(277, 40);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Show Flights and Aircrafts";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // Customersdo
            // 
            AutoScaleDimensions = new SizeF(11F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(936, 650);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Customersdo";
            Text = "Customersdo";
            Load += Customersdo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}