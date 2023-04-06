using System;
using System.Collections.Generic;
using System.Globalization;

namespace ManagementEmployee
{
    public abstract class Employee
    {
        private static int _maxID = 0;
        private int _employeeID;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Position { get; set; }
        public char Gender { get; set; }
        public string? CityOfBirth { get; set; }
        public DateTime BirthDay { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public string EmployeeID
        {
            get
            {
                return $"{BirthDay.Month}/{HireDate.Year}/{_employeeID}";
            }
            set
            {
                _employeeID = int.Parse(value);
            }
        }
        public Employee()
        {
            _maxID++;
            _employeeID = _maxID;
        }
        public virtual string FullName()
        {
            return $"{this.FirstName} {this.LastName}";
        }
        public virtual int GetAge()
        {
            DateTime now = DateTime.Today;
            TimeSpan differenceTime = now - this.BirthDay;
            return Convert.ToInt32(differenceTime.TotalDays)/365;
        }
        public virtual string PlaceAndDateOfBirth()
        {
            return $"{this.CityOfBirth} {this.BirthDay.ToString("dd MMMM yyyy")}";
        }
        public virtual decimal TakeHomePay()
        {
            return 0;
        }
        public virtual string FormatMoney(decimal takeHomePay)
        {
            return takeHomePay.ToString("C", CultureInfo.GetCultureInfo("id-ID"));
        }
    }
}