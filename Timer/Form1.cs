using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int elapsedMilliseconds = 0;
        private double remainingSeconds = 0;

        private void CurrentClockTimer_Tick(object sender, EventArgs e)
        {
            lblCurrentTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            elapsedTimer.Start();
        }
        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            elapsedTimer.Stop();
        }

        private void TimerMilliSeconds_Tick(object sender, EventArgs e)
        {
            elapsedMilliseconds += 10;
            lblElapsedTimeDisplay.Text = TimeSpan.FromMilliseconds(elapsedMilliseconds).ToString(@"hh\:mm\:ss\.ff");
        }

        private void btnResetTimer_Click(object sender, EventArgs e)
        {
            elapsedTimer.Stop();
            elapsedMilliseconds = 0;
            lblElapsedTimeDisplay.Text = TimeSpan.FromMilliseconds(0).ToString(@"hh\:mm\:ss\.ff");
        }

        private string GetCountdownInputAsString()
        {
            return $"{nudHours.Value.ToString()}:{nudMinutes.Value.ToString()}:{nudSeconds.Value.ToString()}";
        }

        private void UpdateCountdownDisplay()
        {
            lblCountdownDisplay.Text = TimeSpan.Parse(GetCountdownInputAsString()).ToString();
        }

        private void TimeValueChanged(object sender, EventArgs e)
        {
            UpdateCountdownDisplay();
        }

        private void ShowCountdownCompleteAlert()
        {
            countdownNotification.Icon = SystemIcons.Application;
            countdownNotification.BalloonTipIcon = ToolTipIcon.Info;
            countdownNotification.BalloonTipTitle = "Stop Watch";
            countdownNotification.BalloonTipText = "Time's up";
            countdownNotification.ShowBalloonTip(10);
        }

        private void ResetCountdownUI()
        {
            countdownTimer.Stop();

            nudHours.Value = 0;
            nudMinutes.Value = 0;
            nudSeconds.Value = 0;
            progressCountdownBar.Value = 0;

            lblCountdownDisplay.Text = "00:00:00";
        }

        private void btnStartCountdown_Click(object sender, EventArgs e)
        {
            if (progressCountdownBar.Value > 0)
            {
                countdownTimer.Start();
                return;
            }

            remainingSeconds = TimeSpan.Parse(lblCountdownDisplay.Text).TotalSeconds;

            if (remainingSeconds > 0)
            {
                progressCountdownBar.Maximum = (int)remainingSeconds;
                countdownTimer.Start();
            }

        }

        private void btnPauseCountdown_Click(object sender, EventArgs e)
        {
            countdownTimer.Stop();
        }

        private void btnResetCountdown_Click(object sender, EventArgs e)
        {
            ResetCountdownUI();
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            if (remainingSeconds <= 0)
            {
                countdownTimer.Stop();
                return;
            }

            lblCountdownDisplay.Text = TimeSpan.FromSeconds(--remainingSeconds).ToString();
            progressCountdownBar.Value++;

            if (remainingSeconds == 0)
            {
                countdownTimer.Stop();
                ShowCountdownCompleteAlert();
            }
        }
    }
}