using System.Diagnostics;

namespace Exam_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject(10, "Jave");
            sub.CreateExam();
            Console.WriteLine("Do You Want to start Exam y|n");

            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Stopwatch SW = new Stopwatch();
                SW.Start();
                sub.Exam.ShowExam();
                Console.WriteLine($"Time Elaped in Exam : {SW.Elapsed} ");

            }
        }
    }
}