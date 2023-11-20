using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Lab
{
    internal class Employee : IComparable
    {
        public int Id { get; set; }
        public string? SecurityLevel { get; set; }
        public double Salary { get; set; }
        public Date HireDate { get; set; }
        public string? Gender { get; set; }

        public Employee(int id, string securityLevel, double salary, Date hiringDate, string gender)
        {
            this.Id = id;
            this.SecurityLevel = securityLevel;
            this.Salary = salary;
            this.HireDate = hiringDate;
            this.Gender = gender;
        }
        public Employee() { }
        public override string ToString()
        {
            return $"the employee {Id} with security level = {SecurityLevel} have a salary ={Salary:c}, hired at {HireDate.Day}-{HireDate.Month}-{HireDate.Year} and gender={Gender}";
        }

        public int CompareTo(object? obj)
        {
            if(obj is Employee newEmp)
            {
                return this.HireDate.CompareTo(newEmp.HireDate);
            }
            else
            {
                Console.WriteLine("invalid Employee");
                return -100;
            }
        }
    }
    struct Date: IComparable
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public Date(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }

        public int CompareTo(object? obj)
        {
            if(obj is Date NewDate)
            {
                if (this.Year < NewDate.Year)
                    return 1;
                else if (this.Year > NewDate.Year)
                    return -1;
                else
                {
                    if ((this.Month < NewDate.Month))
                        return 1;
                    else if((this.Month > NewDate.Month))
                        return -1;
                    else
                    {
                        if (this.Day < NewDate.Day)
                            return 1;
                        else if (this.Day > NewDate.Day)
                            return -1;
                        else return 0;
                    }
                }

            }
            else
            {
                Console.WriteLine("invalid date");
                return -100;
            }

        }
    }
}
