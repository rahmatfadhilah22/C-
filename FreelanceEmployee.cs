using System;
using System.Collections.Generic;
using System.Globalization;

namespace ManagementEmployee
{
    public class FreelanceEmployee : Employee
    {
        public int WorkingHours { get; set; }
        public decimal SallaryPerHours { get; set; }
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
        public static void PrintFreelanceEmployee()
        {
            foreach (FreelanceEmployee employee in Company.FreelanceEmployees.Values)
            {
                System.Console.WriteLine($"ID: {employee.EmployeeID} Full Name : {employee.FullName()}");
            }
        }
        public override decimal TakeHomePay()
        {
            decimal takeHomePay = this.WorkingHours * this.SallaryPerHours;
            return takeHomePay - (takeHomePay * 3 / 100);
        }
        public override string FormatMoney(decimal takeHomePay)
        {
            return takeHomePay.ToString("C", CultureInfo.GetCultureInfo("id-ID"));
        }
    }
}