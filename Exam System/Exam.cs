using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System
{
    abstract class Exam
    {
        #region Attributes
        private int time;
        private int numberOfQuestion;
        protected List<QuestionBase> ArrOfQuetions;
        protected Answers[] ArrOfAnswers;
        private int grade;
        #endregion


        #region Properties
        public int NumberOfQuestion
        {
            get
            {
                return numberOfQuestion;
            }
            set
            {
                if (value > 0)
                    numberOfQuestion = value;
                else
                    throw new ArgumentException("numberOfQuestion must be greater than 0");
            }
        }


        public int Time
        {
            get { return time; }
            set
            {

                if (value > 0)
                    time = value;
                else
                    throw new ArgumentException("time can't be Less than 0");

            }
        }
        #endregion

        public int Grade
        {
            get { return grade; }
            set
            {
                if ((value >= 0))
                    grade = value;
                else
                    throw new ArgumentException("Grade Canot be Negative");

            }
        }

        #region Constructor
        protected Exam()
        {
            ArrOfQuetions = new List<QuestionBase>();
            ArrOfAnswers = new Answers[numberOfQuestion];
        }
        #endregion

        #region Methods
        public abstract void ShowExam();
        public abstract void MakeExamQuestions();
        #endregion
    }
}
