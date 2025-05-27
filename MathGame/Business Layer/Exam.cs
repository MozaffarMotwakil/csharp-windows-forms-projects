using System;
using System.Threading;

public class Exam
{
    public enum Level { Easy, Medium, Hard, Mix };
    public enum Operation { Addition, Subtracttion, Division, Multiplication, Mix };
    
    public Level ExamLevel { set; get; }
    public Operation ExamOperation { set; get; }
    
    private readonly Question[] _questions;
    public Question[] Questions => (Question[])_questions.Clone();

    public byte QuestionsCount { set; get; }
    public byte RightAnswersCount { set; get; }
    public byte WrongAnswersCount { set; get; }
    public byte CurrentQuestionIndex { set; get; }

    public bool IsPassed { set; get; }
    public bool IsStarted { set; get; }
    public bool IsFinished { set; get; }

    public Exam(Level level, Operation operation, byte questionCount)
    {
        this.ExamLevel = level;
        this.ExamOperation = operation;
        this.QuestionsCount = questionCount;
        this._questions = GetQuestions();
    }

    private Question[] GetQuestions()
    {
        Question[] tempQuestions = new Question[QuestionsCount];

        for (byte i = 0; i < QuestionsCount; i++)
        {
            tempQuestions[i] = new Question(ExamLevel, ExamOperation);

            /*
             * I used the Sleep method from the Thread class to prevent question repetition.
             * This is because the speed at which Question objects are created inside the loop is too fast,
             * not giving the Random object in the Question class enough time to generate a new value. As a result, 
             * all question objects end up receiving the same values.
            */
            Thread.Sleep(1); 
        }

        return tempQuestions;
    }

    public float GetFinalPercentage()
    {
        if (!IsFinished)
            throw new InvalidOperationException("Cannot get final percentage before the exam is finished.");

        return (((float)RightAnswersCount / QuestionsCount) * 100);
    }

    public string GetFinalGrade()
    {
        if (!IsFinished)
            throw new InvalidOperationException("Cannot get final grade before the exam is finished.");

        return (GetFinalPercentage() >= 50.0 ? "Pass" : "Fail");
    }

    public class Question
    {
        private readonly Random random = new Random();
            
        public float FirstNumber { get; }
        public float SecondNumber { get; }
        public Exam.Operation Operation { get; }
        public float RightAnswer { get; }
        public float UserAnswer { set; get; }
        public bool IsRightAnswer { set; get; }
            
        private readonly float[] _possibleAnswers;
        public float[] PossibleAnswers => (float[])_possibleAnswers.Clone();
            
        public char OperationSympol
        {
            get
            {
                switch (Operation)
                {
                    case Operation.Addition:
                        return '+';
                    case Operation.Subtracttion:
                        return '-';
                    case Operation.Division:
                        return '÷';
                    case Operation.Multiplication:
                        return '×';
                    default:
                        throw new NotSupportedException($"Operation {Operation} is not supported.");
                }
            }
        }

        public Question(Exam.Level level, Exam.Operation operation)
        {
            this.FirstNumber = GetRandomNumber(level);
            this.SecondNumber = GetRandomNumber(level);
            this.Operation = GetOperation(operation);
            this.RightAnswer = GetRightAnswer();
            this._possibleAnswers = GetPossibleAnswers(level);
        }

        private void ShuffleArray(float[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int randomIndex = random.Next(0, arr.Length);

                float tempValue = arr[i];
                arr[i] = arr[randomIndex];
                arr[randomIndex] = tempValue;
            }
        }

        private float[] GetPossibleAnswers(Exam.Level level)
        {
            float[] temmpArrayWithPossibleAnswers = new float[3];

            temmpArrayWithPossibleAnswers[0] = RightAnswer;

            for (int i = 1; i < 3; i++)
            {
                temmpArrayWithPossibleAnswers[i] = GetRandomNumber(level);
            }

            ShuffleArray(temmpArrayWithPossibleAnswers);

            return temmpArrayWithPossibleAnswers;
        }

        private float GetRightAnswer()
        {
            switch (Operation)
            {
                case Operation.Addition:
                    return FirstNumber + SecondNumber;
                case Operation.Subtracttion:
                    return FirstNumber - SecondNumber;
                case Operation.Division:
                    return FirstNumber / SecondNumber;
                case Operation.Multiplication:
                    return FirstNumber * SecondNumber;
                default:
                    throw new NotSupportedException($"Operation {Operation} is not supported.");
            }
        }

        private Exam.Operation GetRandomOperation()
        {
            return (Exam.Operation)random.Next(0, 4);
        }

        private Exam.Operation GetOperation(Exam.Operation operation)
        {
            return operation == Exam.Operation.Mix ? GetRandomOperation() : operation;
        }

        private Exam.Level GetRandomLevel()
        {
            return (Exam.Level)random.Next(0, 3);
        }

        private float GetRandomNumber(Exam.Level level)
        {
            switch (level)
            {
                case Level.Easy:
                    return random.Next(1, 10);
                case Level.Medium:
                    return random.Next(10, 50);
                case Level.Hard:
                    return random.Next(50, 100);
                case Level.Mix:
                    return GetRandomNumber(GetRandomLevel());
                default:
                    throw new NotSupportedException($"Level {level} is not supported.");
            }
        }

        public void CheckFromTheUserAnswer()
        {
            IsRightAnswer = UserAnswer == RightAnswer;
        }

        public string ToStringQuestion()
        {
            return FirstNumber.ToString() + ' ' + OperationSympol + ' ' + SecondNumber.ToString();
        }

    }
}