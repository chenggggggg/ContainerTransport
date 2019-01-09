namespace ContainerTransportManager
{
    partial class ShipResultForm
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
            this.ShipListView = new System.Windows.Forms.ListView();
            this.ContainerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Row = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Height = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PileWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShipSide = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ShipListView
            // 
            this.ShipListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ContainerId,
            this.Column,
            this.Row,
            this.Height,
            this.Type,
            this.PileWeight,
            this.ShipSide});
            this.ShipListView.Location = new System.Drawing.Point(13, 13);
            this.ShipListView.Name = "ShipListView";
            this.ShipListView.Size = new System.Drawing.Size(985, 425);
            this.ShipListView.TabIndex = 0;
            this.ShipListView.UseCompatibleStateImageBehavior = false;
            this.ShipListView.View = System.Windows.Forms.View.Details;
            // 
            // ContainerId
            // 
            this.ContainerId.Text = "Container number";
            this.ContainerId.Width = 100;
            // 
            // Column
            // 
            this.Column.Text = "Column position";
            this.Column.Width = 100;
            // 
            // Row
            // 
            this.Row.Text = "Row position";
            this.Row.Width = 100;
            // 
            // Height
            // 
            this.Height.Text = "Height position";
            this.Height.Width = 100;
            // 
            // Type
            // 
            this.Type.Text = "Container type";
            // 
            // PileWeight
            // 
            this.PileWeight.Text = "Pileweight";
            this.PileWeight.Width = 100;
            // 
            // ShipSide
            // 
            this.ShipSide.Text = "Ship side";
            // 
            // ShipResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 450);
            this.Controls.Add(this.ShipListView);
            this.Name = "ShipResultForm";
            this.Text = "ShipResultForm";
            this.Load += new System.EventHandler(this.ShipResultForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ShipListView;
        private System.Windows.Forms.ColumnHeader ContainerId;
        private System.Windows.Forms.ColumnHeader Column;
        private System.Windows.Forms.ColumnHeader Row;
        private new System.Windows.Forms.ColumnHeader Height;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader PileWeight;
        private System.Windows.Forms.ColumnHeader ShipSide;
    }
}