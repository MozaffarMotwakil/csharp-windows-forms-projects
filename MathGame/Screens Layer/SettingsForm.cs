using System;
using System.Windows.Forms;

namespace MathGame
{
    public partial class frmSettings : Form
    {
        public Exam.Level Level { set; get; }
        public Exam.Operation Operation { set; get; }
        public byte QuestionsCount { set; get; }

        public frmSettings()
        {
            InitializeComponent();

            Level = Exam.Level.Mix;
            Operation = Exam.Operation.Mix;
            QuestionsCount = 5;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            cbLevels.SelectedIndex = (byte)Level;
            cbOperations.SelectedIndex = (byte)Operation;
            nudQuestionsCount.Value = QuestionsCount;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Level = (Exam.Level)cbLevels.SelectedIndex;
            Operation = (Exam.Operation)cbOperations.SelectedIndex;
            QuestionsCount = (byte)nudQuestionsCount.Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}