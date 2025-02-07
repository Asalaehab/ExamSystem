using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System
{
    internal class Subject
    {
        #region Attributes

        private int subjectId;
        private string? subjectName;


        #endregion

        //Dont forget Validations
        #region Properties

        public int SubjectId
        {
            get { return subjectId; }
            set { subjectId = value; }
        }

        public string? SubjectName
        {
            get { return subjectName; }
            set { subjectName = value; }
        }

        public Exam? Exam { get; set; }

        #endregion


        #region Constructor 
        public Subject(int subjectId, string? subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }
        #endregion


        #region Methods


        public void CreateExam()
        {

            int examtype;
            bool flag;
            do
            {
                Console.Write("Please Enter the type of Exam you Want To Create  (1 for Practical 2 for Final ): ");
                flag = int.TryParse(Console.ReadLine(), out examtype);

                if (examtype < 1 || examtype > 2)
                    flag = false;
            } while (!flag);


            int t;
            do
            {
                Console.Write("Enter the Time For Exam in Minutes : ");
                flag = int.TryParse(Console.ReadLine(), out t);
            } while (!flag);


            int numberOfQuestion;
            do
            {
                Console.Write("Enter number of Questions you Want To Create : ");
                flag = int.TryParse(Console.ReadLine(), out numberOfQuestion);
            } while (!flag);



            //set Exam type
            if (examtype == 1)
            {
                Exam = new Practical_Exam();
            }


            else
            {
                Exam = new Final_Exam();
            }

            //Set Another Attributes in Exam
            Exam.NumberOfQuestion = numberOfQuestion;
            Exam.Time = t;
            for (int i = 0; i < numberOfQuestion; i++)
            {
                //To set Exam Questions
                Exam.MakeExamQuestions();
            }
        }
        #endregion
    }
}
