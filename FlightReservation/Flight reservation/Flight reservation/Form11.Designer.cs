namespace Flight_reservation
{
    partial class DeleteFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteFlight));
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
            label1.Location = new Point(425, 80);
            label1.Name = "label1";
            label1.Size = new Size(125, 36);
            label1.TabIndex = 0;
            label1.Text = "Delete Flight";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(286, 206);
            label2.Name = "label2";
            label2.Size = new Size(51, 24);
            label2.TabIndex = 1;
            label2.Text = "FlightId";
            // 
            // txtId
            // 
            txtId.Location = new Point(387, 203);
            txtId.Name = "txtId";
            txtId.Size = new Size(206, 27);
            txtId.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(439, 319);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DeleteFlight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(954, 654);
            Controls.Add(button1);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DeleteFlight";
            Text = "DeleteFlight";
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