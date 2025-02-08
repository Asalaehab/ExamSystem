using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exam_System
{

    internal class QuestionBase
    {

        #region Attributes
        private int mark;
        private string? body;
        private string? header;
        #endregion

        #region Properties
        public int Mark
        {
            get
            {
                return mark;
            }
            set
            {
                if (value >= 1)
                    mark = value;
                else
                    throw new ArgumentException("Invalid Mark: Mark must be greater than 0.");

            }
        }
        public string? Header
        {
            get
            {
                return header;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    header = value;
                else
                    throw new ArgumentException("Header Can't be Null");
            }
        }
        public string? Body
        {
            get
            {
                return body;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    body = value;
                else
                    throw new ArgumentException("You must put Question Body");
            }
        }
        public Answers? RightAnswer { get; set; }
        public Answers[]? answers { get; set; }
        #endregion

        #region Method
        public virtual void Display()
        {
            Console.WriteLine($"{Header}:");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"{Body}\t Mark({Mark})");
            for(int i = 0;i<answers.Length;i++)
            {
                Console.WriteLine(answers[i]);
            }
        }

        public virtual void AddQuestion()
        {
            string? Question;
            do
            {
                Console.WriteLine("Enter Body for the Question  : ");
                Question = Console.ReadLine();
            } while (string.IsNullOrEmpty(Question));

            Body = Question;
            int grade;
            do
            {
                Console.Write("Enter the Mark For Question : ");
            } while (!int.TryParse(Console.ReadLine(), out grade));
            Mark = grade;
        }

        #endregion
    }
}
