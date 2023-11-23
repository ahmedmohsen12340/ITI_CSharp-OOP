namespace Day6Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem 1
            //////2
            //Point3D point3D = new Point3D(10, 10, 10);
            //Console.WriteLine(point3D);

            //////2.1
            //string s = (string)point3D;
            //Console.WriteLine(s);

            //////3

            //Point p1 = new Point();
            //Point p2 = new Point();

            //Console.WriteLine("enter p1 x:");
            //if (double.TryParse(Console.ReadLine(), out double p1x))
            //{
            //    p1.X = p1x;
            //}
            //else
            //{
            //    Console.WriteLine("Enter a Valid Double value");
            //}
            //Console.WriteLine("enter p1 y:");
            //if (double.TryParse(Console.ReadLine(), out double p1y))
            //{
            //    p1.Y = p1y;
            //}
            //else
            //{
            //    Console.WriteLine("Enter a Valid Double value");
            //}
            //Console.WriteLine("enter p2 x:");
            //if (double.TryParse(Console.ReadLine(), out double p2x))
            //{
            //    p2.X = p2x;
            //}
            //else
            //{
            //    Console.WriteLine("Enter a Valid Double value");
            //}
            //Console.WriteLine("enter p2 y:");
            //if (double.TryParse(Console.ReadLine(), out double p2y))
            //{
            //    p2.Y = p2y;
            //}
            //else
            //{
            //    Console.WriteLine("Enter a Valid Double value");
            //}
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);

            ////4
            //if (p1 == p2)
            //{
            //    Console.WriteLine($"p1 equal p2");
            //}
            //else
            //{
            //    Console.WriteLine($"p1 not equal p2");
            //}
            ////5
            //Point3D[] point3Ds =
            //{
            //    new Point3D(1,4,3),
            //    new Point3D(3,5,6),
            //    new Point3D(2,3,4),
            //    new Point3D(3,4,5),
            //};
            //Array.Sort(point3Ds);
            //foreach (Point3D p in point3Ds)
            //{
            //    Console.WriteLine(p);
            //}

            #endregion
            #region problem 2

            /*
                Duration D1 =new Duration (1,10,15);
                D.ToString(); 
                Output: Hours: 1, Minutes :10 , Seconds :15

                Duration D1 =new Duration (3600);
                D.ToString(); 
                Output: Hours: 1, Minutes :0 , Seconds :0

                Duration D2 =new Duration (7800);
                D.ToString(); 
                Output: Hours: 2, Minutes :10 , Seconds :0

                Duration D3 =new Duration (666);
                D.ToString(); 
                Output: Minutes :11 , Seconds :6
             */

            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1);

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2);

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3);

            Duration D4 = new Duration(666);
            Console.WriteLine(D4);

            #endregion

            D3 = D1 + D2;
            D3 = D1 + 7800;
            D3 = 666 + D3;
            D3 = D1++;
            D3 = --D2;
            if (D1 > D2) { };
            if (D1 <= D2) { };
            if ((bool)D1) { };
            DateTime Obj = (DateTime)D1;


        }
    }
}
