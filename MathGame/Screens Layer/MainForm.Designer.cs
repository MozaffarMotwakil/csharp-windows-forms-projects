namespace MathGame
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExamDetails = new System.Windows.Forms.GroupBox();
            this.lblExamOperation = new System.Windows.Forms.Label();
            this.lblExamLevel = new System.Windows.Forms.Label();
            this.lblExamQuestionsCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ExamResult = new System.Windows.Forms.GroupBox();
            this.lblFinalGrade = new System.Windows.Forms.Label();
            this.lblPercentageResult = new System.Windows.Forms.Label();
            this.lblWrongAnswersCount = new System.Windows.Forms.Label();
            this.lblRightAnswersCount = new System.Windows.Forms.Label();
            this.btnFirstPossibility = new System.Windows.Forms.Button();
            this.btnSecondPossibility = new System.Windows.Forms.Button();
            this.btnThirdPossibility = new System.Windows.Forms.Button();
            this.lblQuestionHeder = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.QuestionInterface = new System.Windows.Forms.Panel();
            this.ExamDetails.SuspendLayout();
            this.ExamResult.SuspendLayout();
            this.QuestionInterface.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Right Answers Count:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(9, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Wrong Answers Count:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(9, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Percentage Result:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(9, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Final Grade: ";
            // 
            // ExamDetails
            // 
            this.ExamDetails.BackColor = System.Drawing.Color.Transparent;
            this.ExamDetails.Controls.Add(this.lblExamOperation);
            this.ExamDetails.Controls.Add(this.lblExamLevel);
            this.ExamDetails.Controls.Add(this.lblExamQuestionsCount);
            this.ExamDetails.Controls.Add(this.label6);
            this.ExamDetails.Controls.Add(this.label1);
            this.ExamDetails.Controls.Add(this.label7);
            this.ExamDetails.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ExamDetails.ForeColor = System.Drawing.Color.White;
            this.ExamDetails.Location = new System.Drawing.Point(56, 76);
            this.ExamDetails.Name = "ExamDetails";
            this.ExamDetails.Size = new System.Drawing.Size(267, 94);
            this.ExamDetails.TabIndex = 1;
            this.ExamDetails.TabStop = false;
            this.ExamDetails.Text = "Exam Details";
            // 
            // lblExamOperation
            // 
            this.lblExamOperation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamOperation.Location = new System.Drawing.Point(138, 38);
            this.lblExamOperation.Name = "lblExamOperation";
            this.lblExamOperation.Size = new System.Drawing.Size(123, 23);
            this.lblExamOperation.TabIndex = 1;
            this.lblExamOperation.Text = "Mix";
            this.lblExamOperation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExamLevel
            // 
            this.lblExamLevel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamLevel.Location = new System.Drawing.Point(138, 15);
            this.lblExamLevel.Name = "lblExamLevel";
            this.lblExamLevel.Size = new System.Drawing.Size(123, 23);
            this.lblExamLevel.TabIndex = 1;
            this.lblExamLevel.Text = "Easy";
            this.lblExamLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExamQuestionsCount
            // 
            this.lblExamQuestionsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamQuestionsCount.Location = new System.Drawing.Point(138, 61);
            this.lblExamQuestionsCount.Name = "lblExamQuestionsCount";
            this.lblExamQuestionsCount.Size = new System.Drawing.Size(102, 23);
            this.lblExamQuestionsCount.TabIndex = 1;
            this.lblExamQuestionsCount.Text = "0";
            this.lblExamQuestionsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(9, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Operation:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(9, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Questions Count:";
            // 
            // ExamResult
            // 
            this.ExamResult.BackColor = System.Drawing.Color.Transparent;
            this.ExamResult.Controls.Add(this.label4);
            this.ExamResult.Controls.Add(this.label2);
            this.ExamResult.Controls.Add(this.lblFinalGrade);
            this.ExamResult.Controls.Add(this.lblPercentageResult);
            this.ExamResult.Controls.Add(this.lblWrongAnswersCount);
            this.ExamResult.Controls.Add(this.lblRightAnswersCount);
            this.ExamResult.Controls.Add(this.label5);
            this.ExamResult.Controls.Add(this.label3);
            this.ExamResult.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ExamResult.ForeColor = System.Drawing.Color.White;
            this.ExamResult.Location = new System.Drawing.Point(56, 169);
            this.ExamResult.Name = "ExamResult";
            this.ExamResult.Size = new System.Drawing.Size(267, 120);
            this.ExamResult.TabIndex = 2;
            this.ExamResult.TabStop = false;
            this.ExamResult.Text = "Exam Result";
            // 
            // lblFinalGrade
            // 
            this.lblFinalGrade.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalGrade.Location = new System.Drawing.Point(186, 87);
            this.lblFinalGrade.Name = "lblFinalGrade";
            this.lblFinalGrade.Size = new System.Drawing.Size(56, 23);
            this.lblFinalGrade.TabIndex = 1;
            this.lblFinalGrade.Text = "Pass";
            this.lblFinalGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPercentageResult
            // 
            this.lblPercentageResult.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentageResult.Location = new System.Drawing.Point(186, 64);
            this.lblPercentageResult.Name = "lblPercentageResult";
            this.lblPercentageResult.Size = new System.Drawing.Size(75, 23);
            this.lblPercentageResult.TabIndex = 1;
            this.lblPercentageResult.Text = "00.00%";
            this.lblPercentageResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWrongAnswersCount
            // 
            this.lblWrongAnswersCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongAnswersCount.Location = new System.Drawing.Point(186, 41);
            this.lblWrongAnswersCount.Name = "lblWrongAnswersCount";
            this.lblWrongAnswersCount.Size = new System.Drawing.Size(56, 23);
            this.lblWrongAnswersCount.TabIndex = 1;
            this.lblWrongAnswersCount.Text = "0";
            this.lblWrongAnswersCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRightAnswersCount
            // 
            this.lblRightAnswersCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightAnswersCount.Location = new System.Drawing.Point(186, 18);
            this.lblRightAnswersCount.Name = "lblRightAnswersCount";
            this.lblRightAnswersCount.Size = new System.Drawing.Size(56, 23);
            this.lblRightAnswersCount.TabIndex = 1;
            this.lblRightAnswersCount.Text = "0";
            this.lblRightAnswersCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFirstPossibility
            // 
            this.btnFirstPossibility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFirstPossibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPossibility.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstPossibility.Location = new System.Drawing.Point(1, 153);
            this.btnFirstPossibility.Name = "btnFirstPossibility";
            this.btnFirstPossibility.Size = new System.Drawing.Size(129, 50);
            this.btnFirstPossibility.TabIndex = 2;
            this.btnFirstPossibility.Text = "0";
            this.btnFirstPossibility.UseVisualStyleBackColor = false;
            this.btnFirstPossibility.Click += new System.EventHandler(this.TakeUserAnswer);
            // 
            // btnSecondPossibility
            // 
            this.btnSecondPossibility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSecondPossibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecondPossibility.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecondPossibility.Location = new System.Drawing.Point(132, 153);
            this.btnSecondPossibility.Name = "btnSecondPossibility";
            this.btnSecondPossibility.Size = new System.Drawing.Size(129, 50);
            this.btnSecondPossibility.TabIndex = 3;
            this.btnSecondPossibility.Text = "0";
            this.btnSecondPossibility.UseVisualStyleBackColor = false;
            this.btnSecondPossibility.Click += new System.EventHandler(this.TakeUserAnswer);
            // 
            // btnThirdPossibility
            // 
            this.btnThirdPossibility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThirdPossibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThirdPossibility.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThirdPossibility.Location = new System.Drawing.Point(263, 153);
            this.btnThirdPossibility.Name = "btnThirdPossibility";
            this.btnThirdPossibility.Size = new System.Drawing.Size(129, 50);
            this.btnThirdPossibility.TabIndex = 4;
            this.btnThirdPossibility.Text = "0";
            this.btnThirdPossibility.UseVisualStyleBackColor = false;
            this.btnThirdPossibility.Click += new System.EventHandler(this.TakeUserAnswer);
            // 
            // lblQuestionHeder
            // 
            this.lblQuestionHeder.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionHeder.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionHeder.Location = new System.Drawing.Point(113, 8);
            this.lblQuestionHeder.Name = "lblQuestionHeder";
            this.lblQuestionHeder.Size = new System.Drawing.Size(124, 28);
            this.lblQuestionHeder.TabIndex = 4;
            this.lblQuestionHeder.Text = "Question";
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNumber.Location = new System.Drawing.Point(230, 8);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(48, 29);
            this.lblQuestionNumber.TabIndex = 5;
            this.lblQuestionNumber.Text = "#1";
            this.lblQuestionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(77, 42);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(243, 73);
            this.lblQuestion.TabIndex = 6;
            this.lblQuestion.Text = "0 + 0";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(55, 345);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(129, 50);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Red;
            this.btnRestart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(193, 345);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(129, 50);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.Location = new System.Drawing.Point(703, 83);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(39, 34);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // QuestionInterface
            // 
            this.QuestionInterface.BackColor = System.Drawing.Color.Transparent;
            this.QuestionInterface.Controls.Add(this.lblQuestion);
            this.QuestionInterface.Controls.Add(this.btnFirstPossibility);
            this.QuestionInterface.Controls.Add(this.btnSecondPossibility);
            this.QuestionInterface.Controls.Add(this.btnThirdPossibility);
            this.QuestionInterface.Controls.Add(this.lblQuestionHeder);
            this.QuestionInterface.Controls.Add(this.lblQuestionNumber);
            this.QuestionInterface.Location = new System.Drawing.Point(333, 81);
            this.QuestionInterface.Name = "QuestionInterface";
            this.QuestionInterface.Size = new System.Drawing.Size(392, 208);
            this.QuestionInterface.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnRestart;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.QuestionInterface);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.ExamResult);
            this.Controls.Add(this.ExamDetails);
            this.Name = "frmMain";
            this.Text = "Math Game";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ExamDetails.ResumeLayout(false);
            this.ExamResult.ResumeLayout(false);
            this.QuestionInterface.ResumeLayout(false);
            this.QuestionInterface.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox ExamDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox ExamResult;
        private System.Windows.Forms.Label lblExamOperation;
        private System.Windows.Forms.Label lblExamLevel;
        private System.Windows.Forms.Label lblExamQuestionsCount;
        private System.Windows.Forms.Label lblFinalGrade;
        private System.Windows.Forms.Label lblPercentageResult;
        private System.Windows.Forms.Label lblWrongAnswersCount;
        private System.Windows.Forms.Label lblRightAnswersCount;
        private System.Windows.Forms.Button btnFirstPossibility;
        private System.Windows.Forms.Button btnSecondPossibility;
        private System.Windows.Forms.Button btnThirdPossibility;
        private System.Windows.Forms.Label lblQuestionHeder;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel QuestionInterface;
    }
}

