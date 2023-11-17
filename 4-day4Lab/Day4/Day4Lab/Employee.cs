using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Lab
{
    internal struct Employee
    {
        public int Id { get; set; }
        public string SecurityLevel { get; set; }
        public double Salary { get; set; }
        public Date HireDate { get; set; }
        public string Gender { get; set; }

        public Employee(int id, string securityLevel, double salary, Date hiringDate, string gender)
        {
            this.Id = id;
            this.SecurityLevel = securityLevel;
            this.Salary = salary;
            this.HireDate = hiringDate;
            this.Gender = gender;
        }
        public override string ToString()
        {
            return $"the employee {Id} with security level = {SecurityLevel} have a salary ={Salary:c}, hired at {HireDate.Day}-{HireDate.Month}-{HireDate.Year} and gender={Gender}";
        }
    }
    struct Date
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
        //public Date(string date)
        //{
        //    int[] components
        //        = int.Parse(date.Split("-"));
        //}
    }
}
