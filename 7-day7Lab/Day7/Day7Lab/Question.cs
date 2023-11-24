using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Lab
{
    public abstract class Question
    {
        public string? Body { get; set; }
        public double? Marks { get; set; }
        public string? Header { get; set; }
        public Answers? Ans { get; set; }
        public List<string>? StudentAnswer { get; set; }

        public Question(string? body, double? marks, string? header,Answers answers)
        {
            Body = body;
            Marks = marks;
            Header = header;
            Ans = answers;
            Console.WriteLine("------------------------------");
            Console.WriteLine(Header);
            Console.WriteLine(Body);

        }
    }

    public class TrueAndFalseQuestion : Question
    {
        public bool[] Choices { get;} = {true, false};
        public TrueAndFalseQuestion(string? body, double? marks, string? header, Answers answers) : base(body, marks, header,answers)
        {
            StudentAnswer = new List<string>();
            Console.WriteLine("Your choices:");
            foreach (var choice in Choices)
            {
                Console.WriteLine(choice);
            }
            Console.WriteLine("------------------------------");
            for (int i = 0; i < Ans.RightAnswers.Count; i++)
            {
                Console.WriteLine($"there are {Ans.RightAnswers.Count} enter your {i+1} answer:");
                string s = Console.ReadLine();
                StudentAnswer.Add(s);
            }
        }
    }

    public class MCQQuestion : Question
    {
        public string[]? Choices { get; set; }
        public MCQQuestion(string? body, double? marks, string? header, string[]? choices, Answers answers) : base(body, marks, header, answers)
        {
            StudentAnswer = new List<string>();
            Choices = choices;
            Console.WriteLine("Your choices:");
            foreach (var choice in Choices)
            {
                Console.WriteLine(choice);
            }
            Console.WriteLine("------------------------------");
            for(int i = 0; i < Ans.RightAnswers.Count; i++)
            {
                Console.WriteLine($"there are {Ans.RightAnswers.Count} enter your {i+1} answer:");
                string s = Console.ReadLine();
                StudentAnswer.Add(s);
            }
        }
    }

}
