namespace Flight_reservation
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAId = new TextBox();
            txtName = new TextBox();
            txtUId = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(400, 377);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(82, 35);
            button1.TabIndex = 0;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 179);
            label1.Name = "label1";
            label1.Size = new Size(57, 24);
            label1.TabIndex = 1;
            label1.Text = "AdminId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 245);
            label2.Name = "label2";
            label2.Size = new Size(80, 24);
            label2.TabIndex = 2;
            label2.Text = "AdminName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 306);
            label3.Name = "label3";
            label3.Size = new Size(50, 24);
            label3.TabIndex = 3;
            label3.Text = "UserId";
            // 
            // txtAId
            // 
            txtAId.BackColor = SystemColors.GradientActiveCaption;
            txtAId.Location = new Point(429, 176);
            txtAId.Margin = new Padding(3, 4, 3, 4);
            txtAId.Name = "txtAId";
            txtAId.Size = new Size(198, 31);
            txtAId.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.GradientActiveCaption;
            txtName.Location = new Point(429, 242);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(198, 31);
            txtName.TabIndex = 5;
            // 
            // txtUId
            // 
            txtUId.BackColor = SystemColors.GradientActiveCaption;
            txtUId.Location = new Point(429, 303);
            txtUId.Margin = new Padding(3, 4, 3, 4);
            txtUId.Name = "txtUId";
            txtUId.Size = new Size(198, 31);
            txtUId.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(429, 63);
            label4.Name = "label4";
            label4.Size = new Size(123, 36);
            label4.TabIndex = 7;
            label4.Text = "Admin Login";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(959, 667);
            Controls.Add(label4);
            Controls.Add(txtUId);
            Controls.Add(txtName);
            Controls.Add(txtAId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Cursor = Cursors.Hand;
            Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.DarkSlateGray;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin";
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAId;
        private TextBox txtName;
        private TextBox txtUId;
        private Label label4;
    }
}