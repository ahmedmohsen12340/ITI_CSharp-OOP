using System.Linq.Expressions;

namespace Day7Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x;
            Exam exam;
            do
            {
                Console.WriteLine("what kind of exam you want?(p: practice/f: final)");
                x = Console.ReadLine();

            } while (x.ToLower() !="p" && x.ToLower() !="f");
            if(x == "p")
            {
                exam = new PracticeExam(
               new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second),
               [
                   new MCQQuestion("2*10=", 5, "MCQ", ["20", "25", "30"],new Answers(new List<string> {"20"})),
                   new TrueAndFalseQuestion("the sun comes from east?", 5, "true or false question",new Answers(new List<string> {"true"})),
                   new MCQQuestion("which of this cities in egypt?", 8, "MCQ", ["alex","cairo","london"],new Answers (new List<string> { "alex","cairo"})),
               ],
               new Subject("science")
               );
                exam.GetResult();
            }
            else if(x == "f")
            {
                exam = new FinalExam(
                   new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second),
                   [
                       new MCQQuestion("2*10=", 5, "MCQ", ["20", "25", "30"], new Answers(new List<string> {"20"})),
                       new TrueAndFalseQuestion("the sun comes from east?", 5, "true or false question", new Answers(new List<string> {"true"})),
                       new MCQQuestion("which of this cities in egypt?", 8, "MCQ", ["alex", "cairo", "london"], new Answers(new List<string> { "alex", "cairo" })),
                   ],
                   new Subject("science")
                   );
                exam.GetResult();
            }
        }
    }
}
