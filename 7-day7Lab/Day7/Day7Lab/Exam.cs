using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Lab
{
    public abstract class Exam
    {
        public DateTime? Time { get; set; }
        public Question[]? Quetions { get; set; }
        public Subject? Subject { get; set; }
        public double? TotalMarks { get; }
        protected double? Result { get; set; } = 0;

        public Exam(DateTime time, Question[] questions, Subject subject)
        {
            Time = time;
            Quetions = questions;
            Subject = subject;
            TotalMarks = SumQuestionGrades(Quetions);
        }
        public abstract void GetResult();
        public double? SumQuestionGrades(Question[] questions)
        {
            double? sum = 0;
            foreach (Question question in questions)
            {
                sum += question.Marks;
            }
            return sum;
        }
    }
    public class FinalExam : Exam
    {
        public FinalExam(DateTime time, Question[] questions, Subject subject) : base(time, questions, subject)
        {
        }

        public override void GetResult()
        {
            foreach (Question question in Quetions)
            {
                for(int i = 0;i<question.StudentAnswer.Count;i++)
                {
                    if (question.Ans.RightAnswers.Contains(question.StudentAnswer[i]))
                    {
                        Result += question.Marks / question.StudentAnswer.Count;
                    }
                }
            }
            Console.WriteLine($"Your result in exam is ={Result} from {TotalMarks}");
        }
    }
    public class PracticeExam : Exam
    {
        public PracticeExam(DateTime time, Question[] questions, Subject subject) : base(time, questions, subject)
        {
        }

        public override void GetResult()
        {
            foreach (Question question in Quetions)
            {
                for (int i = 0; i < question.StudentAnswer.Count; i++)
                {
                    if (question.Ans.RightAnswers.Contains(question.StudentAnswer[i]))
                    {
                        Result += question.Marks/ question.StudentAnswer.Count;
                    }
                }
                Console.WriteLine("----------------------------------");
                Console.WriteLine(question.Body);
                Console.WriteLine("Your Answer:");
                for(int j=0;j< question.StudentAnswer.Count; j++)
                {
                    Console.WriteLine($"{question.StudentAnswer[j]}");
                }
                Console.WriteLine("Right Answer:");
                for (int j = 0; j < question.StudentAnswer.Count; j++)
                {
                    Console.WriteLine($"{question.Ans.RightAnswers[j]}");
                }
            }
            Console.WriteLine($"Your result in exam is ={Result} from {TotalMarks}");
        }
    }
}

