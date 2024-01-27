namespace Flight_reservation
{
    partial class UpdateAircraft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAircraft));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtairId = new TextBox();
            txtModel = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(419, 332);
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
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(306, 190);
            label1.Name = "label1";
            label1.Size = new Size(65, 24);
            label1.TabIndex = 1;
            label1.Text = "AircraftId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(326, 258);
            label2.Name = "label2";
            label2.Size = new Size(45, 24);
            label2.TabIndex = 2;
            label2.Text = "Model";
            // 
            // txtairId
            // 
            txtairId.BackColor = SystemColors.GradientActiveCaption;
            txtairId.Location = new Point(419, 187);
            txtairId.Name = "txtairId";
            txtairId.Size = new Size(220, 31);
            txtairId.TabIndex = 3;
            // 
            // txtModel
            // 
            txtModel.BackColor = SystemColors.GradientActiveCaption;
            txtModel.Location = new Point(419, 255);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(220, 31);
            txtModel.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(366, 78);
            label3.Name = "label3";
            label3.Size = new Size(213, 36);
            label3.TabIndex = 5;
            label3.Text = "Update Aircraft Model";
            // 
            // UpdateAircraft
            // 
            AutoScaleDimensions = new SizeF(7F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(954, 659);
            Controls.Add(label3);
            Controls.Add(txtModel);
            Controls.Add(txtairId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Cursor = Cursors.Hand;
            Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UpdateAircraft";
            Text = "UpdateAircraft";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txtairId;
        private TextBox txtModel;
        private Label label3;
    }
}