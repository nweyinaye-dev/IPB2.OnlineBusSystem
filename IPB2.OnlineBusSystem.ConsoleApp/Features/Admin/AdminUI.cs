using IPB2.OnlineBusSystem.ConsoleApp.Features.Admin.Bus;
using IPB2.OnlineBusSystem.ConsoleApp.Features.Admin.RouteDetail;
using IPB2.OnlineBusSystem.ConsoleApp.Features.Admin.Schdeule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPB2.OnlineBusSystem.ConsoleApp.Features.Admin
{
    public class AdminUI
    {
        public async Task Start()
        {
            while (true)
            {
               await ShowMainMenu();
            }
        }

        public async Task ShowMainMenu()
        {
            Console.WriteLine("\n*** Welcome to Online Bus System ***");
            Console.WriteLine("1) Route");
            Console.WriteLine("2) Bus");
            Console.WriteLine("3) Schedule");
            Console.WriteLine("4) Exit");
            Console.Write("Please choose option: ");
            var choose = Console.ReadLine();
            bool isFlag = int.TryParse(choose, out int res);
            switch (res)
            {
                case 1: await RouteMenu(); break;
                case 2: await BusMenu(); break;
                case 3: await SchdeuleMenu(); break;
                case 4:
                    {
                        Console.WriteLine("Thanks for using.");
                        Environment.Exit(0);
                        break;
                    }
                default: Console.WriteLine("Invalid option.Please try again."); break;
            }

        }

        private async Task RouteMenu()
        {
            await new RouteUI().Start();
        }
        private async Task BusMenu()
        {
            await new BusUI().Start();
        }
        private  async Task SchdeuleMenu()
        {
            await new ScheduleUI().Start();
        }
    }
}
