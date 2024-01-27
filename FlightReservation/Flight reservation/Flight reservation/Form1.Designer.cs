namespace Flight_reservation
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(360, 375);
            button1.Name = "button1";
            button1.Size = new Size(140, 35);
            button1.TabIndex = 0;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(287, 150);
            label1.Name = "label1";
            label1.Size = new Size(50, 24);
            label1.TabIndex = 1;
            label1.Text = "UserId";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(264, 208);
            label2.Name = "label2";
            label2.Size = new Size(73, 24);
            label2.TabIndex = 2;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(296, 266);
            label3.Name = "label3";
            label3.Size = new Size(41, 24);
            label3.TabIndex = 3;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Location = new Point(266, 319);
            label4.Name = "label4";
            label4.Size = new Size(71, 24);
            label4.TabIndex = 4;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.GradientActiveCaption;
            txtID.Location = new Point(392, 143);
            txtID.Name = "txtID";
            txtID.Size = new Size(204, 31);
            txtID.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.GradientActiveCaption;
            txtName.Location = new Point(392, 201);
            txtName.Name = "txtName";
            txtName.Size = new Size(204, 31);
            txtName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.GradientActiveCaption;
            txtEmail.Location = new Point(392, 259);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 31);
            txtEmail.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.GradientActiveCaption;
            txtPassword.Location = new Point(392, 312);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(204, 31);
            txtPassword.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(387, 59);
            label5.Name = "label5";
            label5.Size = new Size(113, 36);
            label5.TabIndex = 9;
            label5.Text = "User Login";
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(942, 655);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.DarkSlateGray;
            Name = "User";
            Text = "User";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label5;
    }
}