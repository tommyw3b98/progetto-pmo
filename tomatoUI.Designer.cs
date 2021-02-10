namespace tomato
{
    partial class tomatoUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.timeLeftText = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Label();
            this.currentStatusText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pomodoriText = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.NumericUpDown();
            this.complete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.counter)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(14, 241);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(150, 100);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(422, 241);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(150, 100);
            this.stopButton.TabIndex = 0;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // timeLeftText
            // 
            this.timeLeftText.AutoSize = true;
            this.timeLeftText.Font = new System.Drawing.Font("Microsoft Sans Serif", 49.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLeftText.Location = new System.Drawing.Point(162, 82);
            this.timeLeftText.Name = "timeLeftText";
            this.timeLeftText.Size = new System.Drawing.Size(247, 95);
            this.timeLeftText.TabIndex = 1;
            this.timeLeftText.Text = "25:00";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(210, 241);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(150, 100);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // left
            // 
            this.left.AutoSize = true;
            this.left.Enabled = false;
            this.left.Location = new System.Drawing.Point(422, 34);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(37, 20);
            this.left.TabIndex = 3;
            this.left.Text = "Left:";
            // 
            // currentStatusText
            // 
            this.currentStatusText.AutoSize = true;
            this.currentStatusText.Enabled = false;
            this.currentStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentStatusText.Location = new System.Drawing.Point(237, 177);
            this.currentStatusText.Name = "currentStatusText";
            this.currentStatusText.Size = new System.Drawing.Size(97, 36);
            this.currentStatusText.TabIndex = 4;
            this.currentStatusText.Text = "Focus";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pomodoriText
            // 
            this.pomodoriText.AutoSize = true;
            this.pomodoriText.Enabled = false;
            this.pomodoriText.Location = new System.Drawing.Point(13, 9);
            this.pomodoriText.Name = "pomodoriText";
            this.pomodoriText.Size = new System.Drawing.Size(77, 20);
            this.pomodoriText.TabIndex = 5;
            this.pomodoriText.Text = "Pomodori:";
            // 
            // counter
            // 
            this.counter.Location = new System.Drawing.Point(119, 7);
            this.counter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(45, 27);
            this.counter.TabIndex = 6;
            this.counter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.counter.ValueChanged += new System.EventHandler(this.PomodoriCounter_ValueChanged);
            // 
            // complete
            // 
            this.complete.AutoSize = true;
            this.complete.Location = new System.Drawing.Point(422, 9);
            this.complete.Name = "complete";
            this.complete.Size = new System.Drawing.Size(77, 20);
            this.complete.TabIndex = 7;
            this.complete.Text = "Complete:";
            // 
            // tomatoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.complete);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.pomodoriText);
            this.Controls.Add(this.currentStatusText);
            this.Controls.Add(this.left);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.timeLeftText);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "tomatoUI";
            this.Text = "tomato 🍅";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.counter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label timeLeftText;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label left;
        private System.Windows.Forms.Label currentStatusText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label pomodoriText;
        private System.Windows.Forms.NumericUpDown counter;
        private System.Windows.Forms.Label complete;
    }
}

