using System;
using System.Collections.Generic;
using System.Globalization;

namespace ManagementEmployee
{
    public class Internship : Employee
    {
        public decimal Sallary { get; set; }
        public decimal TransportationAllowance { get; set; }
        public override string FullName()
        {
            return $"{this.FirstName} {this.LastName}";
        }
        public override int GetAge()
        {
            DateTime now = DateTime.Today;
            TimeSpan differenceTime = now - this.BirthDay;
            return Convert.ToInt32(differenceTime.TotalDays) / 365;
        }
        public static void PrintInternship()
        {
            foreach (Internship employee in Company.Internships.Values)
            {
                System.Console.WriteLine($"ID: {employee.EmployeeID} Full Name : {employee.FullName()}");
            }
        }
        public override decimal TakeHomePay()
        {
            decimal takeHomePay = this.Sallary + this.TransportationAllowance;
            return takeHomePay - (takeHomePay * 3 / 100);
        }
        public override string FormatMoney(decimal takeHomePay)
        {
            return takeHomePay.ToString("C", CultureInfo.GetCultureInfo("id-ID"));
        }
    }
}