namespace tomato
{
    partial class settingsForm
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
            this.applyButton = new System.Windows.Forms.Button();
            this.isCustomCheckBox = new System.Windows.Forms.CheckBox();
            this.focusCounter = new System.Windows.Forms.NumericUpDown();
            this.focusTimeText = new System.Windows.Forms.Label();
            this.relaxTimeText = new System.Windows.Forms.Label();
            this.relaxCounter = new System.Windows.Forms.NumericUpDown();
            this.longRelaxCounter = new System.Windows.Forms.NumericUpDown();
            this.longRelaxTimeText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.focusCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaxCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.longRelaxCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(58, 176);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(94, 29);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // isCustomCheckBox
            // 
            this.isCustomCheckBox.AutoSize = true;
            this.isCustomCheckBox.Location = new System.Drawing.Point(15, 12);
            this.isCustomCheckBox.Name = "isCustomCheckBox";
            this.isCustomCheckBox.Size = new System.Drawing.Size(181, 24);
            this.isCustomCheckBox.TabIndex = 3;
            this.isCustomCheckBox.Text = "Custom time (minutes)";
            this.isCustomCheckBox.UseVisualStyleBackColor = true;
            this.isCustomCheckBox.CheckedChanged += new System.EventHandler(this.isCustomCheckBox_CheckedChanged);
            // 
            // focusCounter
            // 
            this.focusCounter.Enabled = false;
            this.focusCounter.Location = new System.Drawing.Point(140, 53);
            this.focusCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.focusCounter.Name = "focusCounter";
            this.focusCounter.Size = new System.Drawing.Size(48, 27);
            this.focusCounter.TabIndex = 4;
            this.focusCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // focusTimeText
            // 
            this.focusTimeText.AutoSize = true;
            this.focusTimeText.Location = new System.Drawing.Point(12, 53);
            this.focusTimeText.Name = "focusTimeText";
            this.focusTimeText.Size = new System.Drawing.Size(83, 20);
            this.focusTimeText.TabIndex = 5;
            this.focusTimeText.Text = "Focus time:";
            // 
            // relaxTimeText
            // 
            this.relaxTimeText.AutoSize = true;
            this.relaxTimeText.Location = new System.Drawing.Point(12, 95);
            this.relaxTimeText.Name = "relaxTimeText";
            this.relaxTimeText.Size = new System.Drawing.Size(82, 20);
            this.relaxTimeText.TabIndex = 6;
            this.relaxTimeText.Text = "Relax time:";
            // 
            // relaxCounter
            // 
            this.relaxCounter.Enabled = false;
            this.relaxCounter.Location = new System.Drawing.Point(140, 95);
            this.relaxCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.relaxCounter.Name = "relaxCounter";
            this.relaxCounter.Size = new System.Drawing.Size(48, 27);
            this.relaxCounter.TabIndex = 4;
            this.relaxCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // longRelaxCounter
            // 
            this.longRelaxCounter.Enabled = false;
            this.longRelaxCounter.Location = new System.Drawing.Point(140, 136);
            this.longRelaxCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.longRelaxCounter.Name = "longRelaxCounter";
            this.longRelaxCounter.Size = new System.Drawing.Size(48, 27);
            this.longRelaxCounter.TabIndex = 4;
            this.longRelaxCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // longRelaxTimeText
            // 
            this.longRelaxTimeText.AutoSize = true;
            this.longRelaxTimeText.Location = new System.Drawing.Point(12, 136);
            this.longRelaxTimeText.Name = "longRelaxTimeText";
            this.longRelaxTimeText.Size = new System.Drawing.Size(115, 20);
            this.longRelaxTimeText.TabIndex = 7;
            this.longRelaxTimeText.Text = "Long relax time:";
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 217);
            this.ControlBox = false;
            this.Controls.Add(this.longRelaxTimeText);
            this.Controls.Add(this.longRelaxCounter);
            this.Controls.Add(this.relaxCounter);
            this.Controls.Add(this.relaxTimeText);
            this.Controls.Add(this.focusTimeText);
            this.Controls.Add(this.focusCounter);
            this.Controls.Add(this.isCustomCheckBox);
            this.Controls.Add(this.applyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "settingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.focusCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaxCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.longRelaxCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.CheckBox isCustomCheckBox;
        private System.Windows.Forms.NumericUpDown focusCounter;
        private System.Windows.Forms.Label focusTimeText;
        private System.Windows.Forms.Label relaxTimeText;
        private System.Windows.Forms.NumericUpDown relaxCounter;
        private System.Windows.Forms.NumericUpDown longRelaxCounter;
        private System.Windows.Forms.Label longRelaxTimeText;
    }
}