using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System
{
    internal class Practical_Exam : Exam
    {
        public override void MakeExamQuestions()
        {
            QuestionBase mcq = new MCQOneChoice();
            mcq.AddQuestion();
            ArrOfQuetions.Add(mcq);
        }

        public override void ShowExam()
        {
            int grade = 0;
            ArrOfAnswers = new Answers[ArrOfQuetions.Count];

            for (int i = 0; i < ArrOfQuetions.Count; i++)
            {
                Console.Clear();
                Console.WriteLine(ArrOfQuetions[i].Body);
                Console.WriteLine("======================================================");

                ArrOfQuetions[i].Display();
                int ansId = 0;
                string selectedAnswerText = "";
                bool flag;
                if (ArrOfQuetions[i] is MCQOneChoice mcqQuestion)
                {

                    do
                    {
                        Console.Write("Enter Answer number  : ");
                        flag = int.TryParse(Console.ReadLine(), out ansId);
                        if (ansId < 1 || ansId > 3)
                        {
                            Console.WriteLine("Invalid Answer. Please enter 1 or 2 or 3.");
                            flag = false;
                        }

                    } while (!flag);

                    selectedAnswerText = mcqQuestion.choices[ansId - 1];


                }
                ArrOfAnswers[i] = new Answers(ansId, selectedAnswerText);
                if (ArrOfQuetions[i].RightAnswer.Equals(ArrOfAnswers[i]))
                {
                    grade += ArrOfQuetions[i].Mark;
                }
                else
                {
                    grade += 0;
                }

            }
            Grade = grade;
            for (int i = 0; i < ArrOfQuetions.Count; i++)
            {
                Console.WriteLine($"Question No.{i + 1}:  {ArrOfQuetions[i].RightAnswer}");
            }

        }
    }
}
