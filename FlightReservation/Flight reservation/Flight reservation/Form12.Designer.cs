namespace Flight_reservation
{
    partial class DeleteAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAdmin));
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(396, 78);
            label1.Name = "label1";
            label1.Size = new Size(150, 36);
            label1.TabIndex = 0;
            label1.Text = "Remove Admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(285, 207);
            label2.Name = "label2";
            label2.Size = new Size(57, 24);
            label2.TabIndex = 1;
            label2.Text = "AdminId";
            // 
            // txtId
            // 
            txtId.Location = new Point(369, 204);
            txtId.Name = "txtId";
            txtId.Size = new Size(208, 27);
            txtId.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(405, 306);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DeleteAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(959, 638);
            Controls.Add(button1);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DeleteAdmin";
            Text = "DeleteAdmin";
            Load += Form12_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtId;
        private Button button1;
    }
}