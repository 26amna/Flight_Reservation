namespace Flight_reservation
{
    partial class Flight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flight));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtFId = new TextBox();
            txtSource = new TextBox();
            txtDestination = new TextBox();
            txtDeprature = new TextBox();
            txtArrival = new TextBox();
            txtAId = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(448, 54);
            label1.Name = "label1";
            label1.Size = new Size(101, 36);
            label1.TabIndex = 0;
            label1.Text = "Add Flight";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(296, 131);
            label2.Name = "label2";
            label2.Size = new Size(53, 24);
            label2.TabIndex = 1;
            label2.Text = "FlightID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(296, 191);
            label3.Name = "label3";
            label3.Size = new Size(53, 24);
            label3.TabIndex = 2;
            label3.Text = "Source";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(272, 252);
            label4.Name = "label4";
            label4.Size = new Size(75, 24);
            label4.TabIndex = 3;
            label4.Text = "Destination";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(248, 309);
            label5.Name = "label5";
            label5.Size = new Size(97, 24);
            label5.TabIndex = 4;
            label5.Text = "DepratureDate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(268, 361);
            label6.Name = "label6";
            label6.Size = new Size(77, 24);
            label6.TabIndex = 5;
            label6.Text = "ArrivalDate";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(284, 410);
            label7.Name = "label7";
            label7.Size = new Size(67, 24);
            label7.TabIndex = 6;
            label7.Text = "AircraftID";
            // 
            // txtFId
            // 
            txtFId.Location = new Point(387, 128);
            txtFId.Name = "txtFId";
            txtFId.Size = new Size(224, 27);
            txtFId.TabIndex = 7;
            // 
            // txtSource
            // 
            txtSource.Location = new Point(387, 188);
            txtSource.Name = "txtSource";
            txtSource.Size = new Size(224, 27);
            txtSource.TabIndex = 8;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(387, 249);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(224, 27);
            txtDestination.TabIndex = 9;
            // 
            // txtDeprature
            // 
            txtDeprature.Location = new Point(387, 306);
            txtDeprature.Name = "txtDeprature";
            txtDeprature.Size = new Size(224, 27);
            txtDeprature.TabIndex = 10;
            // 
            // txtArrival
            // 
            txtArrival.Location = new Point(387, 358);
            txtArrival.Name = "txtArrival";
            txtArrival.Size = new Size(224, 27);
            txtArrival.TabIndex = 11;
            // 
            // txtAId
            // 
            txtAId.Location = new Point(387, 407);
            txtAId.Name = "txtAId";
            txtAId.Size = new Size(224, 27);
            txtAId.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(404, 476);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Flight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(961, 633);
            Controls.Add(button1);
            Controls.Add(txtAId);
            Controls.Add(txtArrival);
            Controls.Add(txtDeprature);
            Controls.Add(txtDestination);
            Controls.Add(txtSource);
            Controls.Add(txtFId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Flight";
            Text = "Flight";
            Load += Form10_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtFId;
        private TextBox txtSource;
        private TextBox txtDestination;
        private TextBox txtDeprature;
        private TextBox txtArrival;
        private TextBox txtAId;
        private Button button1;
    }
}