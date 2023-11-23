using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Lab
{
    internal class Point3D :Point,IComparable
    {
        public double Z {  get; set; }
        public Point3D()
        {

        }
        public Point3D(double x, double y, double z):base(x,y)
        {
            Z = z;
        }
        public override string ToString()
        {
            return $"( {X} , {Y} , {Z} )";
        }

        public int CompareTo(object? obj)
        {
            if (obj is Point3D point)
            {
                if (X > point.X)
                {
                    return 1;
                }
                else if (X < point.X)
                {
                    return -1 ;
                }
                else
                {
                    if (Y > point.Y)
                        return 1;
                    else if(Y < point.Y)
                        return -1;
                    else 
                        return 0;
                }
            }
            else
            {
                Console.WriteLine("enter a valid point3d");
                return -100;
            }
        }
        public static explicit operator string(Point3D p)
        {
            return p.ToString();
        }
        public static bool operator ==(Point3D a, Point3D b)
        {
            return ((a.X == a.Y) && (b.X == b.Y) && (a.Z==b.Z));
        }
        public static bool operator !=(Point3D a, Point3D b)
        {
            return ((a.X != a.Y) || (b.X != b.Y) || (a.Z!=b.Z));
        }

    }
}
