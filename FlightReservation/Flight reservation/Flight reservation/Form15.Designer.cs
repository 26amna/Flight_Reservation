namespace Flight_reservation
{
    partial class DisplayFlightsAndAircrafts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayFlightsAndAircrafts));
            FlightsAndAircrafts = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)FlightsAndAircrafts).BeginInit();
            SuspendLayout();
            // 
            // FlightsAndAircrafts
            // 
            FlightsAndAircrafts.BackgroundColor = SystemColors.Control;
            FlightsAndAircrafts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FlightsAndAircrafts.Location = new Point(58, 87);
            FlightsAndAircrafts.Name = "FlightsAndAircrafts";
            FlightsAndAircrafts.RowHeadersWidth = 51;
            FlightsAndAircrafts.RowTemplate.Height = 29;
            FlightsAndAircrafts.Size = new Size(714, 260);
            FlightsAndAircrafts.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(372, 382);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DisplayFlightsAndAircrafts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(964, 660);
            Controls.Add(button1);
            Controls.Add(FlightsAndAircrafts);
            Name = "DisplayFlightsAndAircrafts";
            Text = "DisplayFlightsAndAircrafts";
            ((System.ComponentModel.ISupportInitialize)FlightsAndAircrafts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView FlightsAndAircrafts;
        private Button button1;
    }
}