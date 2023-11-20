using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Lab
{
    internal static class CalcStatic
    {
        public static double Add(double first,double second)
        {
            return first + second;
        }
        public static double Subtract(double first, double second)
        {
            return first - second;
        }
        public static double Multiply(double first, double second)
        {
            return first * second;
        }
        public static double Divide(double first, double second)
        {
            return first / second;
        }

    }
    internal class Calc
    {
        public double Add(double first, double second)
        {
            return first + second;
        }
        public double Subtract(double first, double second)
        {
            return first - second;
        }
        public double Multiply(double first, double second)
        {
            return first * second;
        }
        public double Divide(double first, double second)
        {
            return first / second;
        }

    }

}
