using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System
{
    internal class MCQOneChoice: QuestionBase
    {
        public List<string> choices { get; set; }
        public MCQOneChoice()
        {
            Header = "Multiple Chooses Questions (Choose one answer)";
            choices = new List<string>();
            answers = new Answers[3];
        }

        public override void AddQuestion()
        {
            //take Body and Mark.
            base.AddQuestion();


            Console.WriteLine("Enter the Choices Of the Questions : ");
            Console.WriteLine("=======================================================");
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Please Enter the Choise Number{i + 1} : ");
                string? choice;
                choice = Console.ReadLine();
                if (!string.IsNullOrEmpty(choice))
                {
                    choices.Add(choice);

                }

                else
                {
                    Console.WriteLine("Choice cannot be empty. Please enter a valid choice.");
                    i--; // Decrement i to re-enter this choice
                }

            }

            //Take the Right Answer From User
            int n;
            bool flag;
            do
            {
                Console.Write("Specify the Right Answer For Choices : ");
                flag = int.TryParse(Console.ReadLine(), out n);
                if (n < 1 || n > 3)
                    flag = false;
            } while (!flag);

            //Set the Right Answer with The Question
            RightAnswer = new Answers(n, choices[n - 1]);


            for (int i = 0; i < choices.Count; i++)
            {
                answers[i] = new Answers(i + 1, choices[i]);
            }
        }


        //public override void Display()
        //{
        //    base.Display();

        //    for (int i = 0; i < choices.Count; i++)
        //    {
        //        //Console.WriteLine($"{i + 1}. {choices[i]}");

        //        Console.WriteLine(answers[i]);
        //    }
        //}
    }
}
