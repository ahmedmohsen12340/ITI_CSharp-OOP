namespace day1Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first, second,result=0;
            char op;
            Console.Write("Enter first number: ");
            first = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            second = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operator (+ - * /)");
            op = char.Parse(Console.ReadLine());
            switch(op)
            {
                case '+':
                    result = first + second;
                    break;
                case '-':
                    result = first - second;
                    break;
                case '*':
                    result = first * second;
                    break;
                case '/':
                    result = first / second;
                    break;
                default:
                    Console.WriteLine("enter a valid operator (+ - * /)");
                    break;
            }
            Console.WriteLine($"{first} {op} {second} = {result}");
        }
    }
}