using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Lab
{
    internal class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point()
        {

        }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"( {X} , {Y} )";
        }

        public static bool operator ==(Point a, Point b)
        {
            return ((a.X==a.Y)&&(b.X==b.Y));
        }
        public static bool operator !=(Point a, Point b)
        {
            return ((a.X != a.Y) || (b.X != b.Y));
        }

        #region override equals
        //public override bool Equals(object? obj)
        //{
        //    if((obj is  Point point)&&(point != null))
        //    {
        //        if (X.Equals(point.X))
        //        {
        //            if (Y.Equals(point.Y))
        //            {
        //                return true ;
        //            }
        //        }
        //        return false ;
        //    }
        //    else
        //    {
        //        return false ;
        //    } 
        //}
        #endregion

    }

}
