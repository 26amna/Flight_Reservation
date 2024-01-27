namespace Flight_reservation
{
    partial class UpdatePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePassword));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            txtNewPassword = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(370, 341);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Menu;
            label1.Location = new Point(277, 196);
            label1.Name = "label1";
            label1.Size = new Size(50, 24);
            label1.TabIndex = 1;
            label1.Text = "UserId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 264);
            label2.Name = "label2";
            label2.Size = new Size(98, 24);
            label2.TabIndex = 2;
            label2.Text = "NewPassword";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.GradientInactiveCaption;
            txtId.Location = new Point(370, 193);
            txtId.Name = "txtId";
            txtId.Size = new Size(216, 31);
            txtId.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = SystemColors.GradientActiveCaption;
            txtNewPassword.Location = new Point(370, 261);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(216, 31);
            txtNewPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(370, 92);
            label3.Name = "label3";
            label3.Size = new Size(177, 36);
            label3.TabIndex = 5;
            label3.Text = "Update Password";
            // 
            // UpdatePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(921, 633);
            Controls.Add(label3);
            Controls.Add(txtNewPassword);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Cursor = Cursors.Hand;
            Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.DarkSlateGray;
            Margin = new Padding(3, 4, 3, 4);
            Name = "UpdatePassword";
            Text = "UpdatePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txtId;
        private TextBox txtNewPassword;
        private Label label3;
    }
}