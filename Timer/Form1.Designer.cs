namespace Timer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCurrentClock = new System.Windows.Forms.TabPage();
            this.lblCurrentTimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageTimer = new System.Windows.Forms.TabPage();
            this.btnResetT = new System.Windows.Forms.Button();
            this.btnStopT = new System.Windows.Forms.Button();
            this.btnStartT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblElapsedTimeDisplay = new System.Windows.Forms.Label();
            this.tabPageStopWatch = new System.Windows.Forms.TabPage();
            this.btnResetCountdown = new System.Windows.Forms.Button();
            this.btnPauseCountdown = new System.Windows.Forms.Button();
            this.btnStartCountdown = new System.Windows.Forms.Button();
            this.lblCountdownDisplay = new System.Windows.Forms.Label();
            this.progressCountdownBar = new System.Windows.Forms.ProgressBar();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentClockTimer = new System.Windows.Forms.Timer(this.components);
            this.elapsedTimer = new System.Windows.Forms.Timer(this.components);
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.countdownNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageCurrentClock.SuspendLayout();
            this.tabPageTimer.SuspendLayout();
            this.tabPageStopWatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCurrentClock);
            this.tabControl1.Controls.Add(this.tabPageTimer);
            this.tabControl1.Controls.Add(this.tabPageStopWatch);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(645, 296);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCurrentClock
            // 
            this.tabPageCurrentClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageCurrentClock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageCurrentClock.Controls.Add(this.lblCurrentTimer);
            this.tabPageCurrentClock.Controls.Add(this.label1);
            this.tabPageCurrentClock.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageCurrentClock.Location = new System.Drawing.Point(4, 28);
            this.tabPageCurrentClock.Name = "tabPageCurrentClock";
            this.tabPageCurrentClock.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCurrentClock.Size = new System.Drawing.Size(637, 264);
            this.tabPageCurrentClock.TabIndex = 0;
            this.tabPageCurrentClock.Text = "Current Clock";
            // 
            // lblCurrentTimer
            // 
            this.lblCurrentTimer.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTimer.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTimer.Location = new System.Drawing.Point(165, 130);
            this.lblCurrentTimer.Name = "lblCurrentTimer";
            this.lblCurrentTimer.Size = new System.Drawing.Size(335, 57);
            this.lblCurrentTimer.TabIndex = 2;
            this.lblCurrentTimer.Text = "00:00:00 AM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Clock";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageTimer
            // 
            this.tabPageTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageTimer.Controls.Add(this.btnResetT);
            this.tabPageTimer.Controls.Add(this.btnStopT);
            this.tabPageTimer.Controls.Add(this.btnStartT);
            this.tabPageTimer.Controls.Add(this.label3);
            this.tabPageTimer.Controls.Add(this.lblElapsedTimeDisplay);
            this.tabPageTimer.Location = new System.Drawing.Point(4, 28);
            this.tabPageTimer.Name = "tabPageTimer";
            this.tabPageTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTimer.Size = new System.Drawing.Size(637, 264);
            this.tabPageTimer.TabIndex = 1;
            this.tabPageTimer.Text = "Timer";
            // 
            // btnResetT
            // 
            this.btnResetT.BackColor = System.Drawing.Color.Red;
            this.btnResetT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetT.Location = new System.Drawing.Point(436, 193);
            this.btnResetT.Name = "btnResetT";
            this.btnResetT.Size = new System.Drawing.Size(92, 43);
            this.btnResetT.TabIndex = 3;
            this.btnResetT.Text = "Reset";
            this.btnResetT.UseVisualStyleBackColor = false;
            this.btnResetT.Click += new System.EventHandler(this.btnResetTimer_Click);
            // 
            // btnStopT
            // 
            this.btnStopT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStopT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopT.ForeColor = System.Drawing.Color.Black;
            this.btnStopT.Location = new System.Drawing.Point(279, 193);
            this.btnStopT.Name = "btnStopT";
            this.btnStopT.Size = new System.Drawing.Size(92, 43);
            this.btnStopT.TabIndex = 3;
            this.btnStopT.Text = "Stop";
            this.btnStopT.UseVisualStyleBackColor = false;
            this.btnStopT.Click += new System.EventHandler(this.btnStopTimer_Click);
            // 
            // btnStartT
            // 
            this.btnStartT.BackColor = System.Drawing.Color.Lime;
            this.btnStartT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartT.ForeColor = System.Drawing.Color.Black;
            this.btnStartT.Location = new System.Drawing.Point(122, 193);
            this.btnStartT.Name = "btnStartT";
            this.btnStartT.Size = new System.Drawing.Size(92, 43);
            this.btnStartT.TabIndex = 3;
            this.btnStartT.Text = "Start";
            this.btnStartT.UseVisualStyleBackColor = false;
            this.btnStartT.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(272, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Timer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblElapsedTimeDisplay
            // 
            this.lblElapsedTimeDisplay.AutoSize = true;
            this.lblElapsedTimeDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblElapsedTimeDisplay.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElapsedTimeDisplay.ForeColor = System.Drawing.Color.White;
            this.lblElapsedTimeDisplay.Location = new System.Drawing.Point(162, 92);
            this.lblElapsedTimeDisplay.Name = "lblElapsedTimeDisplay";
            this.lblElapsedTimeDisplay.Size = new System.Drawing.Size(322, 58);
            this.lblElapsedTimeDisplay.TabIndex = 0;
            this.lblElapsedTimeDisplay.Text = "00:00:00.00";
            // 
            // tabPageStopWatch
            // 
            this.tabPageStopWatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageStopWatch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageStopWatch.Controls.Add(this.btnResetCountdown);
            this.tabPageStopWatch.Controls.Add(this.btnPauseCountdown);
            this.tabPageStopWatch.Controls.Add(this.btnStartCountdown);
            this.tabPageStopWatch.Controls.Add(this.lblCountdownDisplay);
            this.tabPageStopWatch.Controls.Add(this.progressCountdownBar);
            this.tabPageStopWatch.Controls.Add(this.nudSeconds);
            this.tabPageStopWatch.Controls.Add(this.nudMinutes);
            this.tabPageStopWatch.Controls.Add(this.nudHours);
            this.tabPageStopWatch.Controls.Add(this.label6);
            this.tabPageStopWatch.Controls.Add(this.label5);
            this.tabPageStopWatch.Controls.Add(this.label4);
            this.tabPageStopWatch.Controls.Add(this.label2);
            this.tabPageStopWatch.Location = new System.Drawing.Point(4, 28);
            this.tabPageStopWatch.Name = "tabPageStopWatch";
            this.tabPageStopWatch.Size = new System.Drawing.Size(637, 264);
            this.tabPageStopWatch.TabIndex = 2;
            this.tabPageStopWatch.Text = "Stop Watch";
            // 
            // btnResetCountdown
            // 
            this.btnResetCountdown.BackColor = System.Drawing.Color.Red;
            this.btnResetCountdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetCountdown.Location = new System.Drawing.Point(378, 205);
            this.btnResetCountdown.Name = "btnResetCountdown";
            this.btnResetCountdown.Size = new System.Drawing.Size(92, 43);
            this.btnResetCountdown.TabIndex = 9;
            this.btnResetCountdown.Text = "Reset";
            this.btnResetCountdown.UseVisualStyleBackColor = false;
            this.btnResetCountdown.Click += new System.EventHandler(this.btnResetCountdown_Click);
            // 
            // btnPauseCountdown
            // 
            this.btnPauseCountdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPauseCountdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPauseCountdown.ForeColor = System.Drawing.Color.Black;
            this.btnPauseCountdown.Location = new System.Drawing.Point(277, 205);
            this.btnPauseCountdown.Name = "btnPauseCountdown";
            this.btnPauseCountdown.Size = new System.Drawing.Size(92, 43);
            this.btnPauseCountdown.TabIndex = 8;
            this.btnPauseCountdown.Text = "Pause";
            this.btnPauseCountdown.UseVisualStyleBackColor = false;
            this.btnPauseCountdown.Click += new System.EventHandler(this.btnPauseCountdown_Click);
            // 
            // btnStartCountdown
            // 
            this.btnStartCountdown.BackColor = System.Drawing.Color.Lime;
            this.btnStartCountdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartCountdown.ForeColor = System.Drawing.Color.Black;
            this.btnStartCountdown.Location = new System.Drawing.Point(177, 205);
            this.btnStartCountdown.Name = "btnStartCountdown";
            this.btnStartCountdown.Size = new System.Drawing.Size(92, 43);
            this.btnStartCountdown.TabIndex = 7;
            this.btnStartCountdown.Text = "Start";
            this.btnStartCountdown.UseVisualStyleBackColor = false;
            this.btnStartCountdown.Click += new System.EventHandler(this.btnStartCountdown_Click);
            // 
            // lblCountdownDisplay
            // 
            this.lblCountdownDisplay.AutoSize = true;
            this.lblCountdownDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblCountdownDisplay.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdownDisplay.ForeColor = System.Drawing.Color.White;
            this.lblCountdownDisplay.Location = new System.Drawing.Point(200, 142);
            this.lblCountdownDisplay.Name = "lblCountdownDisplay";
            this.lblCountdownDisplay.Size = new System.Drawing.Size(245, 58);
            this.lblCountdownDisplay.TabIndex = 6;
            this.lblCountdownDisplay.Text = "00:00:00";
            // 
            // progressCountdownBar
            // 
            this.progressCountdownBar.Location = new System.Drawing.Point(177, 113);
            this.progressCountdownBar.Name = "progressCountdownBar";
            this.progressCountdownBar.Size = new System.Drawing.Size(293, 23);
            this.progressCountdownBar.TabIndex = 5;
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(455, 73);
            this.nudSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(90, 27);
            this.nudSeconds.TabIndex = 4;
            this.nudSeconds.ValueChanged += new System.EventHandler(this.TimeValueChanged);
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(280, 73);
            this.nudMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(90, 27);
            this.nudMinutes.TabIndex = 4;
            this.nudMinutes.ValueChanged += new System.EventHandler(this.TimeValueChanged);
            // 
            // nudHours
            // 
            this.nudHours.Location = new System.Drawing.Point(104, 72);
            this.nudHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(90, 27);
            this.nudHours.TabIndex = 4;
            this.nudHours.ValueChanged += new System.EventHandler(this.TimeValueChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(451, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Seconds";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(276, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Minutes";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(100, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hours";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(218, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stop Watch";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentClockTimer
            // 
            this.CurrentClockTimer.Enabled = true;
            this.CurrentClockTimer.Interval = 1000;
            this.CurrentClockTimer.Tick += new System.EventHandler(this.CurrentClockTimer_Tick);
            // 
            // elapsedTimer
            // 
            this.elapsedTimer.Interval = 1;
            this.elapsedTimer.Tick += new System.EventHandler(this.TimerMilliSeconds_Tick);
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // countdownNotification
            // 
            this.countdownNotification.Text = "notifyIcon1";
            this.countdownNotification.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(669, 320);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageCurrentClock.ResumeLayout(false);
            this.tabPageCurrentClock.PerformLayout();
            this.tabPageTimer.ResumeLayout(false);
            this.tabPageTimer.PerformLayout();
            this.tabPageStopWatch.ResumeLayout(false);
            this.tabPageStopWatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCurrentClock;
        private System.Windows.Forms.TabPage tabPageTimer;
        private System.Windows.Forms.TabPage tabPageStopWatch;
        private System.Windows.Forms.Label lblCurrentTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer CurrentClockTimer;
        private System.Windows.Forms.Label lblElapsedTimeDisplay;
        private System.Windows.Forms.Button btnResetT;
        private System.Windows.Forms.Button btnStopT;
        private System.Windows.Forms.Button btnStartT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer elapsedTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCountdownDisplay;
        private System.Windows.Forms.ProgressBar progressCountdownBar;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.Button btnStartCountdown;
        private System.Windows.Forms.Button btnPauseCountdown;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.NotifyIcon countdownNotification;
        private System.Windows.Forms.Button btnResetCountdown;
    }
}

