using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System
{
    internal class Answers: IEquatable<Answers>
    {
        #region Attributes
        private int answerID;
        private string? answerText;

        #endregion


        #region Properties

        public int AnswerId
        {
            get { return answerID; }
            set
            {
                if (value > 0) answerID = value;
                else Console.WriteLine("Invalid Id Answer");
            }
        }
        public string? AnswerText
        {
            get { return answerText; }
            set
            {
                if (!string.IsNullOrEmpty(value)) answerText = value;
                else Console.WriteLine("Canot be Null or Empty ");
            }
        }


        #endregion


        #region Constructor
        public Answers(int answerId, string? answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public Answers()
        {

        }
        #endregion


        #region Methods
        public override string ToString()
        {
            return $"{AnswerId}. {AnswerText}";
        }

        #endregion

        public bool Equals(Answers? other)
        {
            if (other == null) return false;
            return AnswerText == other.answerText && AnswerId == other.AnswerId;
        }


    }
}
