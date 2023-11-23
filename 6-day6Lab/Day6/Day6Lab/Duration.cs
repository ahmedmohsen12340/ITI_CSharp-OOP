using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Lab
{
    internal class Duration
    {
        public int Hours {  get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int secs)
        {
            Hours = secs/3600;
            Minutes = (secs%3600)/60;
            Seconds = (secs%60);
        }
        public override string ToString()
        {
            return $"Hours: {Hours} , Minutes : {Minutes}, Seconds : {Seconds}";
        }
        public override bool Equals(object? obj)
        {
            if ((obj is Duration dur) && (dur != null))
            {
               return ((Hours.Equals(dur.Hours))&&(Minutes.Equals(dur.Minutes))&&(Seconds.Equals(dur.Seconds)));
            }
            return false ;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode()/(Hours*Minutes*Seconds);
        }

        public static Duration operator +(Duration a, Duration b)
        {
            Duration res = new Duration(a.Hours+b.Hours,a.Minutes+b.Minutes,a.Seconds+b.Seconds);
            return res ;
        }
        public static Duration operator +(Duration a, int b)
        {
            Duration res = new Duration((a.Hours/3600)+(a.Minutes/60)+a.Seconds+b);
            return res;
        }
        public static Duration operator +(int b,Duration a)
        {
            Duration res = new Duration((a.Hours / 3600) + (a.Minutes / 60) + a.Seconds + b);
            return res;
        }
        public static Duration operator ++(Duration a)
        {
            a.Minutes++;
            return a ;
        }
        public static Duration operator --(Duration a)
        {
            a.Minutes--;
            return a ;
        }
        public static bool operator >(Duration a, Duration b)
        {
            if (a.Hours > b.Hours)
                return true;
            else if(a.Hours == b.Hours)
            {
                if(a.Minutes > b.Minutes)
                    return true;
                else if(a.Seconds> b.Seconds)
                    return true;
                else
                    return false;
            }
            return false;
        }
        public static bool operator <(Duration a, Duration b)
        {
            if (a.Hours < b.Hours)
                return true;
            else if (a.Hours == b.Hours)
            {
                if (a.Minutes < b.Minutes)
                    return true;
                else if (a.Seconds < b.Seconds)
                    return true;
                else
                    return false;
            }
            return false;
        }
        public static bool operator >=(Duration a, Duration b)
        {
            if (a.Hours > b.Hours)
                return true;
            else if (a.Hours == b.Hours)
            {
                if (a.Minutes > b.Minutes)
                    return true;
                else if (a.Seconds > b.Seconds)
                    return true;
                else if(a.Seconds == b.Seconds)
                    return true;
            }
            return false;
        }
        public static bool operator <=(Duration a, Duration b)
        {
            if (a.Hours < b.Hours)
                return true;
            else if (a.Hours == b.Hours)
            {
                if (a.Minutes < b.Minutes)
                    return true;
                else if (a.Seconds < b.Seconds)
                    return true;
                else if (a.Seconds == b.Seconds)
                    return true;
            }
            return false;
        }
        public static explicit operator bool(Duration a)
        {
            if (a.Hours != default && a.Minutes != default && a.Seconds != default)
                return true;
            else return false;
        }
        public static explicit operator DateTime(Duration a)
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month,DateTime.Now.Day, a.Hours,a.Minutes,a.Seconds);
        }
    }
}
