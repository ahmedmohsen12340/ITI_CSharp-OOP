namespace Day2Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem 1
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("enter a number:");
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine($"the sum ={sum}");
            #endregion

            #region problem 2
            int sum2 = 0;
            while (sum2 < 100)
            {
                Console.WriteLine("enter a number:");
                int num = int.Parse(Console.ReadLine());
                sum2 += num;
                Console.WriteLine($"sum = {sum2}");
            }
            Console.WriteLine($"sum exceed 100, sum={sum2} the loop ended");
            #endregion

            #region problem 3
            char key = ' ';
            bool cond = true;
            do
            {
                Console.WriteLine(
                    "a: new\n" +
                    "b: display\n" +
                    "e: Exit"
                    );
                key = char.Parse(Console.ReadLine());
                key = char.ToLower(key);
                switch (key)
                {
                    //case 'A':
                    case 'a':
                        Console.WriteLine("new");
                        break;
                    //case 'B':
                    case 'b':
                        Console.WriteLine("Display");
                        break;
                    //case 'E':
                    case 'e':
                        cond = false;
                        break;
                    default:
                        Console.WriteLine("enter a valid character (a b e)");
                        break;
                }

            } while (cond);

            #endregion        
        }
    }
}