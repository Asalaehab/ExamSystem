using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System
{
    internal class TFQuestions : QuestionBase
    {
        public TFQuestions()
        {
            Header = "True | False Question";
        }

        public override void AddQuestion()
        {

            base.AddQuestion();
            bool flag;
            int rightAns = 0;
            do
            {
                Console.Write("Please Enter Right Answer For the Question 1 For True 2 For False : ");
                flag = int.TryParse(Console.ReadLine(), out rightAns);
                if (rightAns < 1 || rightAns > 2)
                    flag = false;
            } while (!flag);

            string textans = (rightAns == 1) ? "True" : "False";
            RightAnswer = new(rightAns, textans);


        }

        public override void Display()
        {
            base.Display();

            Console.WriteLine("1. True                       2.False");
        }
    }
}
