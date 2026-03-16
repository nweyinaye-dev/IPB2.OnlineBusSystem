using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPB2.OnlineBusSystem.ConsoleApp.Features.Admin
{
    public class AdminUI
    {
        //private AccountService accountService = new AccountService();
        //private string? _loginMobileNo;
        public void Start()
        {
            while (true)
            {
                ShowMainMenu();
            }
        }

        public void ShowMainMenu()
        {
            Console.WriteLine("\n*** Welcome to Online Bus System ***");
            Console.WriteLine("1) Route");
            Console.WriteLine("2) Bus");
            Console.WriteLine("3) Schedule");
            Console.Write("Please choose option: ");
            var choose = Console.ReadLine();
            bool isFlag = int.TryParse(choose, out int res);
            switch (res)
            {
                case 1: RouteMenu(); break;
                case 2: BusMenu(); break;
                case 3: SchdeuleMenu(); break;
                case 4:
                    {
                        Console.WriteLine("Thanks for using.");
                        //Exit();
                        break;
                    }
                default: Console.WriteLine("Invalid option.Please try again."); break;
            }

        }

        private void RouteMenu()
        {
            Console.WriteLine("\n*** Route Menu ***");
            Console.WriteLine("1) Route Listing");
            Console.WriteLine("2) Create Route");
            Console.WriteLine("3) Update Route");
            Console.WriteLine("4) Delete Route");
            Console.Write("Please choose option: ");
            var choose = Console.ReadLine();
            bool isFlag = int.TryParse(choose, out int res);
            switch (res)
            {
                case 1: RouteMenu(); break;
                case 2: BusMenu(); break;
                case 3: SchdeuleMenu(); break;
                case 4:
                    {
                        Console.WriteLine("Thanks for using.");
                        //Exit();
                        break;
                    }
                default: Console.WriteLine("Invalid option.Please try again."); break;
            }
        }
        private void BusMenu()
        {
            Console.WriteLine("\n*** Bus Menu ***");
            Console.WriteLine("1) Bus Listing");
            Console.WriteLine("2) Create Bus");
            Console.WriteLine("3) Update Bus");
            Console.WriteLine("4) Delete Bus");
            Console.Write("Please choose option: ");
            var choose = Console.ReadLine();
            bool isFlag = int.TryParse(choose, out int res);
        }
        private void SchdeuleMenu()
        {
            Console.WriteLine("\n*** Schedule Menu ***");
            Console.WriteLine("1) Schedule Listing");
            Console.WriteLine("2) Create Schedule");
            Console.WriteLine("3) Update Schedule");
            Console.WriteLine("4) Delete Schedule");
            Console.Write("Please choose option: ");
            var choose = Console.ReadLine();
            bool isFlag = int.TryParse(choose, out int res);
        }
    }
}
