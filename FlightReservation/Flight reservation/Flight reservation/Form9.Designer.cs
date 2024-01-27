namespace Flight_reservation
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCId = new TextBox();
            txtName = new TextBox();
            txtUId = new TextBox();
            txtBaggage = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(373, 77);
            label1.Name = "label1";
            label1.Size = new Size(158, 36);
            label1.TabIndex = 0;
            label1.Text = "Customer Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(229, 178);
            label2.Name = "label2";
            label2.Size = new Size(81, 24);
            label2.TabIndex = 1;
            label2.Text = "CustomerID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(204, 227);
            label3.Name = "label3";
            label3.Size = new Size(102, 24);
            label3.TabIndex = 2;
            label3.Text = "CustomerName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(256, 274);
            label4.Name = "label4";
            label4.Size = new Size(50, 24);
            label4.TabIndex = 3;
            label4.Text = "UserId";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(248, 326);
            label5.Name = "label5";
            label5.Size = new Size(61, 24);
            label5.TabIndex = 4;
            label5.Text = "Baggage";
            // 
            // txtCId
            // 
            txtCId.Location = new Point(342, 175);
            txtCId.Name = "txtCId";
            txtCId.Size = new Size(202, 27);
            txtCId.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(342, 224);
            txtName.Name = "txtName";
            txtName.Size = new Size(202, 27);
            txtName.TabIndex = 6;
            // 
            // txtUId
            // 
            txtUId.Location = new Point(342, 274);
            txtUId.Name = "txtUId";
            txtUId.Size = new Size(202, 27);
            txtUId.TabIndex = 7;
            // 
            // txtBaggage
            // 
            txtBaggage.Location = new Point(342, 323);
            txtBaggage.Name = "txtBaggage";
            txtBaggage.Size = new Size(202, 27);
            txtBaggage.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(332, 387);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(935, 661);
            Controls.Add(button1);
            Controls.Add(txtBaggage);
            Controls.Add(txtUId);
            Controls.Add(txtName);
            Controls.Add(txtCId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Customer";
            Text = "Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCId;
        private TextBox txtName;
        private TextBox txtUId;
        private TextBox txtBaggage;
        private Button button1;
    }
}