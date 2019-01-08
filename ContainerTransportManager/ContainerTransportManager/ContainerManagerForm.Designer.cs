namespace ContainerTransportManager
{
    partial class ContainerManagerForm
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
            this.RegularRadioButton = new System.Windows.Forms.RadioButton();
            this.ContainerTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.CooledRadioButton = new System.Windows.Forms.RadioButton();
            this.ValuableRadioButton = new System.Windows.Forms.RadioButton();
            this.ContainerGroupBox = new System.Windows.Forms.GroupBox();
            this.WeightNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.AddContainerButton = new System.Windows.Forms.Button();
            this.ContainerTypeGroupBox.SuspendLayout();
            this.ContainerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeightNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // RegularRadioButton
            // 
            this.RegularRadioButton.AutoSize = true;
            this.RegularRadioButton.Location = new System.Drawing.Point(34, 32);
            this.RegularRadioButton.Name = "RegularRadioButton";
            this.RegularRadioButton.Size = new System.Drawing.Size(79, 21);
            this.RegularRadioButton.TabIndex = 0;
            this.RegularRadioButton.TabStop = true;
            this.RegularRadioButton.Text = "Regular";
            this.RegularRadioButton.UseVisualStyleBackColor = true;
            // 
            // ContainerTypeGroupBox
            // 
            this.ContainerTypeGroupBox.Controls.Add(this.ValuableRadioButton);
            this.ContainerTypeGroupBox.Controls.Add(this.CooledRadioButton);
            this.ContainerTypeGroupBox.Controls.Add(this.RegularRadioButton);
            this.ContainerTypeGroupBox.Location = new System.Drawing.Point(19, 31);
            this.ContainerTypeGroupBox.Name = "ContainerTypeGroupBox";
            this.ContainerTypeGroupBox.Size = new System.Drawing.Size(151, 126);
            this.ContainerTypeGroupBox.TabIndex = 1;
            this.ContainerTypeGroupBox.TabStop = false;
            this.ContainerTypeGroupBox.Text = "Container type";
            // 
            // CooledRadioButton
            // 
            this.CooledRadioButton.AutoSize = true;
            this.CooledRadioButton.Location = new System.Drawing.Point(34, 59);
            this.CooledRadioButton.Name = "CooledRadioButton";
            this.CooledRadioButton.Size = new System.Drawing.Size(73, 21);
            this.CooledRadioButton.TabIndex = 1;
            this.CooledRadioButton.TabStop = true;
            this.CooledRadioButton.Text = "Cooled";
            this.CooledRadioButton.UseVisualStyleBackColor = true;
            // 
            // ValuableRadioButton
            // 
            this.ValuableRadioButton.AutoSize = true;
            this.ValuableRadioButton.Location = new System.Drawing.Point(34, 86);
            this.ValuableRadioButton.Name = "ValuableRadioButton";
            this.ValuableRadioButton.Size = new System.Drawing.Size(84, 21);
            this.ValuableRadioButton.TabIndex = 2;
            this.ValuableRadioButton.TabStop = true;
            this.ValuableRadioButton.Text = "Valuable";
            this.ValuableRadioButton.UseVisualStyleBackColor = true;
            // 
            // ContainerGroupBox
            // 
            this.ContainerGroupBox.Controls.Add(this.AddContainerButton);
            this.ContainerGroupBox.Controls.Add(this.WeightLabel);
            this.ContainerGroupBox.Controls.Add(this.WeightNumUpDown);
            this.ContainerGroupBox.Controls.Add(this.ContainerTypeGroupBox);
            this.ContainerGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ContainerGroupBox.Name = "ContainerGroupBox";
            this.ContainerGroupBox.Size = new System.Drawing.Size(194, 280);
            this.ContainerGroupBox.TabIndex = 2;
            this.ContainerGroupBox.TabStop = false;
            this.ContainerGroupBox.Text = "New container";
            // 
            // WeightNumUpDown
            // 
            this.WeightNumUpDown.Location = new System.Drawing.Point(53, 190);
            this.WeightNumUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.WeightNumUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.WeightNumUpDown.Name = "WeightNumUpDown";
            this.WeightNumUpDown.Size = new System.Drawing.Size(85, 22);
            this.WeightNumUpDown.TabIndex = 2;
            this.WeightNumUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(50, 170);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(56, 17);
            this.WeightLabel.TabIndex = 3;
            this.WeightLabel.Text = "Weight:";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(230, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(546, 280);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // AddContainerButton
            // 
            this.AddContainerButton.Location = new System.Drawing.Point(19, 233);
            this.AddContainerButton.Name = "AddContainerButton";
            this.AddContainerButton.Size = new System.Drawing.Size(151, 31);
            this.AddContainerButton.TabIndex = 4;
            this.AddContainerButton.Text = "Add";
            this.AddContainerButton.UseVisualStyleBackColor = true;
            // 
            // ContainerManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ContainerGroupBox);
            this.Name = "ContainerManagerForm";
            this.Text = "ContainerManagerForm";
            this.ContainerTypeGroupBox.ResumeLayout(false);
            this.ContainerTypeGroupBox.PerformLayout();
            this.ContainerGroupBox.ResumeLayout(false);
            this.ContainerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeightNumUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RegularRadioButton;
        private System.Windows.Forms.GroupBox ContainerTypeGroupBox;
        private System.Windows.Forms.RadioButton ValuableRadioButton;
        private System.Windows.Forms.RadioButton CooledRadioButton;
        private System.Windows.Forms.GroupBox ContainerGroupBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.NumericUpDown WeightNumUpDown;
        private System.Windows.Forms.Button AddContainerButton;
        private System.Windows.Forms.ListView listView1;
    }
}