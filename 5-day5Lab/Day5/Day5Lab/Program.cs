﻿using Day5Lab;

namespace Day4Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Problem 1
            int[] arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Before:");
            //foreach (int ele in arr)
            //{
            //    Console.Write(ele + " ");
            //}
            //ValueArr(arr);
            //Console.WriteLine("\nAfter:");
            //foreach (int ele in arr)
            //{
            //    Console.Write(ele + " ");
            //}

            //Console.WriteLine("Before:");
            //foreach (int ele in arr)
            //{
            //    Console.Write(ele + " ");
            //}
            //RefArr(ref arr);
            //Console.WriteLine("\nAfter:");
            //foreach (int ele in arr)
            //{
            //    Console.Write(ele + " ");
            //}
            #endregion

            #region problem 2
            //int day, month, year;
            //Employee[] employees = new Employee[3];
            ////{
            ////    new Employee(1, "Admin", 10000, new Date(5, 10, 2020), "male"),
            ////    new Employee(2, "modiator", 8000, new Date(5, 1, 2021), "female"),
            ////    new Employee(3, "modiator", 7000, new Date(5, 12, 2022), "male"),
            ////};
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    employees[i]= new Employee();
            //    Console.WriteLine($"Enter Id for employee num {i + 1} :");
            //    employees[i].Id = int.Parse(Console.ReadLine());

            //    Console.WriteLine($"Enter SecurityLevel for employee num {i + 1} :");
            //    employees[i].SecurityLevel = Console.ReadLine();

            //    Console.WriteLine($"Enter salary for employee num {i + 1} :");
            //    employees[i].Salary = double.Parse(Console.ReadLine());

            //    Console.WriteLine($"Enter hireDate day for employee num {i + 1} :");
            //    day = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Enter hireDate month for employee num {i + 1} :");
            //    month = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Enter hireDate year for employee num {i + 1} :");
            //    year = int.Parse(Console.ReadLine());
            //    employees[i].HireDate = new Date(day, month, year);

            //    Console.WriteLine($"Enter Gender for employee num {i + 1} :");
            //    employees[i].Gender = Console.ReadLine();

            //}

            //Array.Sort(employees);
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}
            #endregion

            #region problem 3

            //static
            Console.WriteLine("Static:");
            Console.WriteLine(CalcStatic.Add(5,2));
            Console.WriteLine(CalcStatic.Subtract(5, 2));
            Console.WriteLine(CalcStatic.Multiply(5, 2));
            Console.WriteLine(CalcStatic.Divide(5, 2));

            //non-static
            Calc calc = new Calc();
            Console.WriteLine("Non Static:");
            Console.WriteLine(calc.Add(5, 2));
            Console.WriteLine(calc.Subtract(5, 2));
            Console.WriteLine(calc.Multiply(5, 2));
            Console.WriteLine(calc.Divide(5, 2));



            #endregion
        }
    }
}
