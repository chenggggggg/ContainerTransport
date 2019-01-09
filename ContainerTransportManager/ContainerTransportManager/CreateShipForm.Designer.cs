namespace ContainerTransportManager
{
    partial class CreateShipForm
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
            this.ContinueButton = new System.Windows.Forms.Button();
            this.ColumnNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.RowNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.ColumnLabel = new System.Windows.Forms.Label();
            this.RowsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(215, 226);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(110, 43);
            this.ContinueButton.TabIndex = 0;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // ColumnNumUpDown
            // 
            this.ColumnNumUpDown.Location = new System.Drawing.Point(282, 87);
            this.ColumnNumUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ColumnNumUpDown.Name = "ColumnNumUpDown";
            this.ColumnNumUpDown.Size = new System.Drawing.Size(101, 22);
            this.ColumnNumUpDown.TabIndex = 1;
            this.ColumnNumUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // RowNumUpDown
            // 
            this.RowNumUpDown.Location = new System.Drawing.Point(282, 131);
            this.RowNumUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RowNumUpDown.Name = "RowNumUpDown";
            this.RowNumUpDown.Size = new System.Drawing.Size(101, 22);
            this.RowNumUpDown.TabIndex = 2;
            this.RowNumUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ColumnLabel
            // 
            this.ColumnLabel.AutoSize = true;
            this.ColumnLabel.Location = new System.Drawing.Point(121, 89);
            this.ColumnLabel.Name = "ColumnLabel";
            this.ColumnLabel.Size = new System.Drawing.Size(159, 17);
            this.ColumnLabel.TabIndex = 3;
            this.ColumnLabel.Text = "Columns (front to back):";
            // 
            // RowsLabel
            // 
            this.RowsLabel.AutoSize = true;
            this.RowsLabel.Location = new System.Drawing.Point(230, 133);
            this.RowsLabel.Name = "RowsLabel";
            this.RowsLabel.Size = new System.Drawing.Size(46, 17);
            this.RowsLabel.TabIndex = 4;
            this.RowsLabel.Text = "Rows:";
            // 
            // CreateShipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 337);
            this.Controls.Add(this.RowsLabel);
            this.Controls.Add(this.ColumnLabel);
            this.Controls.Add(this.RowNumUpDown);
            this.Controls.Add(this.ColumnNumUpDown);
            this.Controls.Add(this.ContinueButton);
            this.Name = "CreateShipForm";
            this.Text = "Create ship";
            ((System.ComponentModel.ISupportInitialize)(this.ColumnNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.NumericUpDown ColumnNumUpDown;
        private System.Windows.Forms.NumericUpDown RowNumUpDown;
        private System.Windows.Forms.Label ColumnLabel;
        private System.Windows.Forms.Label RowsLabel;
    }
}

