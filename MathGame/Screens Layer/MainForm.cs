using System;
using System.Windows.Forms;

namespace MathGame
{
    public partial class frmMain : Form
    {
        private frmSettings settingsForm;
        private Exam _exam;

        public frmMain()
        {
            InitializeComponent();
        }

        private void CreateExam()
        {
            _exam = new Exam(settingsForm.Level, settingsForm.Operation, settingsForm.QuestionsCount);
        }

        private void SetExamDetailsInterface()
        {
            lblExamLevel.Text = settingsForm.Level.ToString();
            lblExamOperation.Text = settingsForm.Operation.ToString();
            lblExamQuestionsCount.Text = settingsForm.QuestionsCount.ToString();
        }

        private void SetExamResultInterface()
        {
            lblRightAnswersCount.Text = _exam.RightAnswersCount.ToString();
            lblWrongAnswersCount.Text = _exam.WrongAnswersCount.ToString();
            lblPercentageResult.Text = _exam.GetFinalPercentage().ToString("F2") + '%';
            lblFinalGrade.Text = _exam.GetFinalGrade();
        }

        private void DisplayExamResultInterface(bool dispaly)
        {
            ExamResult.Visible = dispaly;
        }

        private void DisplayQuestionInterface(bool dispaly)
        {
            QuestionInterface.Visible = dispaly;
        }

        private void SetQuestionNumber(byte questionIndex)
        {
            lblQuestionNumber.Text = $"#{questionIndex + 1}";
        }

        private void PrintQuestionOnScreen(byte questionIndex)
        {
            lblQuestion.Text = _exam.Questions[questionIndex].ToStringQuestion();
        }

        private void SetQuestionPossibilities(byte questionIndex)
        {
            btnFirstPossibility.Text = _exam.Questions[questionIndex].PossibleAnswers[0].ToString();
            btnSecondPossibility.Text = _exam.Questions[questionIndex].PossibleAnswers[1].ToString();
            btnThirdPossibility.Text = _exam.Questions[questionIndex].PossibleAnswers[2].ToString();
        }

        private void ShowQuestion(byte questionIndex)
        {
            SetQuestionNumber(questionIndex);
            PrintQuestionOnScreen(questionIndex);
            SetQuestionPossibilities(questionIndex);
        }

        private void ShowNextQuestion()
        {
            _exam.CurrentQuestionIndex++;

            if (_exam.CurrentQuestionIndex < _exam.QuestionsCount)
            {
                ShowQuestion(_exam.CurrentQuestionIndex);
            }
            else
            {
                _exam.IsFinished = true;
                MessageBox.Show("You are solved all the questions, you can now see the exam result.", "Exam completion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FinishExam();
            }
        }

        private void StartExam()
        {
            DisplayExamResultInterface(false);
            DisplayQuestionInterface(true);
            ShowQuestion(_exam.CurrentQuestionIndex); // Show First Question
        }

        private void FinishExam()
        {
            _exam.IsStarted = false;

            DisplayQuestionInterface(false);
            SetExamResultInterface();
            DisplayExamResultInterface(true);
        }

        private void ProcessTheAnswerChosen(Button button)
        {
            _exam.Questions[_exam.CurrentQuestionIndex].UserAnswer = Convert.ToSingle(button.Text);
            _exam.Questions[_exam.CurrentQuestionIndex].CheckFromTheUserAnswer();

            if (_exam.Questions[_exam.CurrentQuestionIndex].IsRightAnswer)
            {
                _exam.RightAnswersCount++;
            }
            else
            {
                _exam.WrongAnswersCount++;
            }

        }

        private void TakeUserAnswer(object sender, EventArgs e)
        {
            Button button = sender as Button;

            ProcessTheAnswerChosen(button);
            ShowNextQuestion();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            settingsForm = new frmSettings();
            CreateExam();
            DisplayQuestionInterface(false);
            DisplayExamResultInterface(false);
            SetExamDetailsInterface();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_exam.IsFinished)
                CreateExam();

            if (!_exam.IsStarted)
            {
                _exam.IsStarted = true;
                StartExam();
            }
            else
            {
                MessageBox.Show("The exam is already in progress, cannot begin a new exam.", "Failed Start The Exam", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (!_exam.IsStarted)
            {
                settingsForm.ShowDialog();
                CreateExam();
                SetExamDetailsInterface();
            }
            else
            {
                MessageBox.Show("The exam is already in progress, cannot modify settings.", "Failed Modify Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (_exam.IsStarted)
            {
                if (MessageBox.Show("Are you sure you want to restart the exam ? a new exam will start.", "Restart The Exam", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    CreateExam();
                    _exam.IsStarted = true;
                    StartExam();
                }
            }
        }
    }
}
