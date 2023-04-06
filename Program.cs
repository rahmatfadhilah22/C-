using System;
using System.Collections.Generic;
namespace ManagementEmployee
{
    class Program
    {
        static void Main(String[] args)
        {
            Company.Initialization();
            MainMenu();
        }
        public static void MainMenu()
        {
            System.Console.WriteLine("Silahkan pilih menu dibawah ini\n1. Lihat semua Employee\n2. Info Detail Employee\n3. Keluar aplikasi");
            string? inputUser = Console.ReadLine();
            switch (inputUser)
            {
                case "1":
                    Company.PrintAllEmployee();
                    MainMenu();
                    break;
                case "2":
                    System.Console.WriteLine("Masukkan ID Employee yang ingin dicari");
                    string? key = Console.ReadLine();
                    Company.SearchEmployeeByKey(key);
                    MainMenu();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    System.Console.WriteLine("Pilihan yang tersedia hanya 1,2, dan 3");
                    MainMenu();
                    break;
            }
        }
    }
}
