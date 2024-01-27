namespace Flight_reservation
{
    partial class FlightsDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightsDisplay));
            FlightsTable = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)FlightsTable).BeginInit();
            SuspendLayout();
            // 
            // FlightsTable
            // 
            FlightsTable.BackgroundColor = SystemColors.Control;
            FlightsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FlightsTable.Location = new Point(12, 72);
            FlightsTable.Name = "FlightsTable";
            FlightsTable.RowHeadersVisible = false;
            FlightsTable.RowHeadersWidth = 51;
            FlightsTable.RowTemplate.Height = 29;
            FlightsTable.Size = new Size(758, 255);
            FlightsTable.TabIndex = 0;
            FlightsTable.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(391, 365);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FlightsDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(965, 637);
            Controls.Add(button1);
            Controls.Add(FlightsTable);
            Name = "FlightsDisplay";
            Text = "FlightsDisplay";
            ((System.ComponentModel.ISupportInitialize)FlightsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView FlightsTable;
        private Button button1;
    }
}