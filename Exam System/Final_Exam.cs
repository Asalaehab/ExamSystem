using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exam_System
{
   
    internal class Final_Exam : Exam
    {
 
        public override void MakeExamQuestions()
        {
            int Questiontype;
            bool flag;
            do
            {
                Console.Write("Choose the Type Of Question  (1 for MCQ || 2 for True OR False ) : ");

                flag = int.TryParse(Console.ReadLine(), out Questiontype);

                if (Questiontype < 1 || Questiontype > 2)
                    flag = false;

            } while (!flag);



            if (Questiontype == 1)
            {
                QuestionBase mcq = new MCQOneChoice();

                mcq.AddQuestion();

                ArrOfQuetions.Add(mcq);
            }


            else
            {
                QuestionBase TF = new TFQuestions();

                TF.AddQuestion();

                ArrOfQuetions.Add(TF);

            }
        }


        public override void ShowExam()
        {
            int grade = 0;
            int TotalGrade = 0;
            ArrOfAnswers = new Answers[ArrOfQuetions.Count];
            for (int i = 0; i < ArrOfQuetions.Count; i++)
            {
                Console.Clear();
                ArrOfQuetions[i].Display();

                int ansId = 0;
                string selectedAnswerText = "";
                bool flag;
                ArrOfAnswers[i] = new Answers();

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
                    //Console.WriteLine($"{selectedAnswerText} :  {i + 1}");

                }


                else if (ArrOfQuetions[i] is TFQuestions)
                {

                    do
                    {
                        Console.Write("Enter 1 for True  2 for False : ");
                        flag = int.TryParse(Console.ReadLine(), out ansId);
                        if (ansId < 1 || ansId > 2)
                        {
                            Console.Write("Invalid Answer. Please enter 1 or 2 ");
                            flag = false;
                        }
                        selectedAnswerText = (ansId == 1) ? "True" : "False";
                    } while (!flag);

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
                TotalGrade += ArrOfQuetions[i].Mark;
            }


            Grade = grade;

            Console.Clear();
            Console.WriteLine("your Answers : ");
            for (int i = 0; i < NumberOfQuestion; i++)
            {
                Console.WriteLine($"Q{i+1})     {ArrOfQuetions[i].Body} : {ArrOfAnswers[i].AnswerText}");
            }

            Console.WriteLine($"Exam Grade is  : {Grade} out of {TotalGrade}");

        }
    }
}
