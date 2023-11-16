namespace day3Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem 1
            //double[,] grades = new double[3, 4];
            ////{
            ////    { 5, 10, 20, 30 },
            ////    { 5, 10, 20, 30 },
            ////    { 5, 10, 20, 30 }
            ////};

            //for (int i = 0; i < grades.GetLength(0); i++)
            //{
            //    for (int j = 0; j < grades.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"enter grade of student: {i + 1} subject: {j + 1} :");
            //        grades[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //double[] sum = new double[grades.GetLength(1)];
            //double[] avg = new double[grades.GetLength(1)];
            //for (int i = 0; i < grades.GetLength(1); i++)
            //{
            //    for (int j = 0; j < grades.GetLength(0); j++)
            //    {
            //        sum[i] += grades[j, i];
            //    }
            //    avg[i] = sum[i] / grades.GetLength(0);
            //    Console.WriteLine($"the average for subject {i + 1} = {avg[i]}");
            //}


            #endregion        }

            #region problem 2
            //int n;
            //Console.WriteLine("Enter array length:");
            //n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //int[,] dist = new int[n, n];
            //int max = 0;
            //int current = -1;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"enter the {i + 1} value:");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    current = arr[i];
            //    for (int j = arr.Length - 1; j > i; j--)
            //    {
            //        if (arr[j] == current)
            //        {
            //            dist[i, j] = j - i - 1;
            //        }
            //    }
            //}
            //for (int i = 0; i < dist.GetLength(0); i++)
            //{
            //    for (int j = 0; j < dist.GetLength(1); j++)
            //    {
            //        if (max < dist[i, j])
            //            max = dist[i, j];
            //    }
            //}
            //Console.WriteLine($"the max length ={max}");
            #endregion

            #region problem 3
            //Console.WriteLine("enter the input:");
            //string? input = Console.ReadLine();
            //string[] words = input.Split();
            //for (int i = words.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{words[i]} ");
            //}
            #endregion

            #region problem 4.1
            //string x;
            //int sum = 0;
            //for (int i = 0; i <= 1000000; i++)
            //{
            //    x = i.ToString();
            //    foreach (var digit in x)
            //        if (digit == '1')
            //            sum++;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region problem 4.2
            //int sum = 0;
            //int j = 0;
            //for (int i = 0; i <= 1000; i++)
            //{
            //    j = i;
            //    while (j % 10 != 0 || j > 0)
            //    {
            //        if (i % 10 == 1)
            //            sum++;
            //        j /= 10;
            //    }
            //}
            //Console.WriteLine(sum);
            #endregion

            #region problem 4.2
            //int sum = 0;
            ////int j = 0;
            //sum = (int)(6 * Math.Pow(10, 5) + 1);
            //Console.WriteLine(sum);
            #endregion

        }
    }
}