using System;
using System.Collections.Generic;

namespace ManagementEmployee
{
    public static class Company
    {
        public static Dictionary<string, PermanentEmployee> PermanentEmployees { get; set; } = new Dictionary<string, PermanentEmployee>();
        public static Dictionary<string, ContractEmplyee> ContractEmployees { get; set; } = new Dictionary<string, ContractEmplyee>();
        public static Dictionary<string, FreelanceEmployee> FreelanceEmployees { get; set; } = new Dictionary<string, FreelanceEmployee>();
        public static Dictionary<string, Internship> Internships { get; set; } = new Dictionary<string, Internship>();
        public static Dictionary<string, Employee> Employees { get; set; } = new Dictionary<string, Employee>();
        public static void Initialization()
        {
            PermanentEmployeeData();
            ContractEmplyeeData();
            FreelanceEmployeeData();
            InternshipData();
        }
        public static void PrintAllEmployee()
        {
            PermanentEmployee.PrintPermanentEmployee();
            ContractEmplyee.PrintContractEmployee();
            FreelanceEmployee.PrintFreelanceEmployee();
            Internship.PrintInternship();
        }
        public static void SearchEmployeeByKey(string key)
        {
            bool found = false;
            foreach (Employee employee in Employees.Values)
            {
                if (employee.EmployeeID.Equals(key))
                {
                    found = true;
                    System.Console.WriteLine($"ID: {employee.EmployeeID}\n" + 
                    $"Full Name : {employee.FullName()}\n" +
                    $"Gender : {employee.Gender}\n" +
                    $"Position : {employee.Position}\n" +
                    $"Birth Date : {employee.PlaceAndDateOfBirth()}({employee.GetAge()} year)\n" +
                    $"Address : {employee.Address}\n" +
                    $"Phone Number : {employee.PhoneNumber}\n" +
                    $"Hire Date : {employee.HireDate.ToString("dd MMMM yyyy")}\n" +
                    $"Take Home Pay : {employee.FormatMoney(employee.TakeHomePay())}");
                }
            }
            if (!found)
            {
                System.Console.WriteLine($"Employee dengan nomor Id {key} tidak ditemukan");
            }
        }
        private static void PermanentEmployeeData()
        {
            PermanentEmployee amir = new PermanentEmployee()
            {
                FirstName = "Amir",
                LastName = "Setiabudi",
                Gender = 'M',
                Position = "Junior Frontend Programmer",
                CityOfBirth = "Samarinda",
                BirthDay = new DateTime(2000, 06, 12),
                Address = "M.Yamin No.12",
                PhoneNumber = "08214098654",
                HireDate = new DateTime(2022, 06, 11),
                BasicSalary = 5_000_000,
                AllowanceSalary = 1_000_000,
                Bonus = 2_000_000
            };
            PermanentEmployee sandra = new PermanentEmployee()
            {
                FirstName = "Sandra",
                LastName = "Antonio",
                Gender = 'F',
                Position = "Senior Frontend Programmer",
                CityOfBirth = "Tenggarong",
                BirthDay = new DateTime(1999, 02, 20),
                Address = "S.Parman No. 43",
                PhoneNumber = "081323456865",
                HireDate = new DateTime(2021, 01, 01),
                BasicSalary = 6_000_000,
                AllowanceSalary = 1_000_000,
                Bonus = 3_000_000
            };
            PermanentEmployee wisnu = new PermanentEmployee()
            {
                FirstName = "Wisnu",
                LastName = "Sadewo",
                Gender = 'M',
                Position = "Manager",
                CityOfBirth = "Samarinda",
                BirthDay = new DateTime(1999, 03, 11),
                Address = "Jl Mugirejo, dekat Pesantren Gus Rofiq",
                PhoneNumber = "0856438987",
                HireDate = new DateTime(2021, 06, 12),
                BasicSalary = 10_000_000,
                AllowanceSalary = 2_000_000,
                Bonus = 5_000_000
            };
            PermanentEmployees.Add(amir.EmployeeID, amir);
            PermanentEmployees.Add(sandra.EmployeeID, sandra);
            PermanentEmployees.Add(wisnu.EmployeeID, wisnu);
            Employees.Add(amir.EmployeeID, amir);
            Employees.Add(sandra.EmployeeID, sandra);
            Employees.Add(wisnu.EmployeeID, wisnu);

        }
        private static void ContractEmplyeeData()
        {
            ContractEmplyee igor = new ContractEmplyee()
            {
                FirstName = "Igor",
                LastName = "Satriani",
                Gender = 'M',
                Position = "Researcher",
                CityOfBirth = "Jakarta",
                BirthDay = new DateTime(2000, 05, 12),
                Address = "Jl. Palaran",
                PhoneNumber = "0897654321",
                HireDate = new DateTime(2023, 01, 12),
                BasicSalary = 12_000_000,
                TransportationAllowance = 2_000_000
            };
            ContractEmplyee akbar = new ContractEmplyee()
            {
                FirstName = "Akbar",
                LastName = "Perdana",
                Gender = 'M',
                Position = "Trainer",
                CityOfBirth = "Palu",
                BirthDay = new DateTime(1999, 04, 18),
                Address = "Jl. Gunung kelua",
                PhoneNumber = "08975312112",
                HireDate = new DateTime(2022, 08, 09),
                BasicSalary = 8_000_000,
                TransportationAllowance = 1_000_000
            };
            ContractEmployees.Add(igor.EmployeeID, igor);
            ContractEmployees.Add(akbar.EmployeeID, akbar);
            Employees.Add(igor.EmployeeID, igor);
            Employees.Add(akbar.EmployeeID, akbar);
        }
        private static void FreelanceEmployeeData()
        {
            FreelanceEmployee ansar = new FreelanceEmployee()
            {
                FirstName = "Ansar",
                LastName = "Maulana",
                Gender = 'M',
                Position = "Surveyor",
                CityOfBirth = "Samarinda",
                BirthDay = new DateTime(2000, 11, 12),
                Address = "Jl. Sentosa",
                PhoneNumber = "0987123653",
                HireDate = new DateTime(2022, 12, 11),
                SallaryPerHours = 40_000,
                WorkingHours = 160
            };
            FreelanceEmployees.Add(ansar.EmployeeID, ansar);
            Employees.Add(ansar.EmployeeID, ansar);
        }
        private static void InternshipData()
        {
            Internship dani = new Internship()
            {
                FirstName = "Akhmad",
                LastName = "Dani",
                Gender = 'M',
                Position = "Trainee",
                CityOfBirth = "Kota Bangun",
                BirthDay = new DateTime(2000, 06, 11),
                Address = "Jl. TVRI",
                PhoneNumber = "0857124564323",
                HireDate = new DateTime(2023, 01, 31),
                Sallary = 2_000_000,
                TransportationAllowance = 500_000
            };
            Internships.Add(dani.EmployeeID, dani);
            Employees.Add(dani.EmployeeID, dani);
        }
    }
}