namespace Flight_reservation
{
    partial class Aircraft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aircraft));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtID = new TextBox();
            txtModel = new TextBox();
            txtManufacturer = new TextBox();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(365, 152);
            label1.Name = "label1";
            label1.Size = new Size(65, 24);
            label1.TabIndex = 0;
            label1.Text = "AircarftId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(381, 222);
            label2.Name = "label2";
            label2.Size = new Size(45, 24);
            label2.TabIndex = 1;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(342, 294);
            label3.Name = "label3";
            label3.Size = new Size(89, 24);
            label3.TabIndex = 2;
            label3.Text = "Manufacturer";
            label3.Click += label3_Click;
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.GradientActiveCaption;
            txtID.Location = new Point(471, 144);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(186, 31);
            txtID.TabIndex = 3;
            // 
            // txtModel
            // 
            txtModel.BackColor = SystemColors.GradientActiveCaption;
            txtModel.Location = new Point(471, 218);
            txtModel.Margin = new Padding(3, 4, 3, 4);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(186, 31);
            txtModel.TabIndex = 4;
            // 
            // txtManufacturer
            // 
            txtManufacturer.BackColor = SystemColors.GradientActiveCaption;
            txtManufacturer.Location = new Point(471, 285);
            txtManufacturer.Margin = new Padding(3, 4, 3, 4);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(186, 31);
            txtManufacturer.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(412, 374);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(82, 35);
            button1.TabIndex = 6;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(428, 53);
            label4.Name = "label4";
            label4.Size = new Size(124, 36);
            label4.TabIndex = 7;
            label4.Text = "Add Aircraft";
            // 
            // Aircraft
            // 
            AutoScaleDimensions = new SizeF(7F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(968, 595);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtManufacturer);
            Controls.Add(txtModel);
            Controls.Add(txtID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.DarkSlateGray;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Aircraft";
            Text = "Aircraft";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtID;
        private TextBox txtModel;
        private TextBox txtManufacturer;
        private Button button1;
        private Label label4;
    }
}