using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPB2.OnlineBusSystem.ConsoleApp.Features.Admin.RouteDetail
{
    public class RouteUI
    {
        RouteService _routeService = new RouteService();
        public void Start()
        {
             ShowMainMenu();
        }
        public async Task ShowMainMenu()
        {
            while (true)
            {
                Console.WriteLine("\n*** Route Menu ***");
                Console.WriteLine("1) Route Listing");
                Console.WriteLine("2) Create Route");
                Console.WriteLine("3) Update Route");
                Console.WriteLine("4) Delete Route");
                Console.Write("Please choose option: ");

                var choose = Console.ReadLine();
                bool isFlag = int.TryParse(choose, out int res);

                if (!isFlag)
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    continue;
                }

                switch (res)
                {
                    case 1:
                        await GetRoutesAsync();
                        break;

                    case 4:
                        Console.WriteLine("Thanks for using.");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private async Task GetRoutesAsync()
        {
            int pageNo = 1;
            int pageSize = 10;

            while (true)
            {
                Console.Write("Enter pageNo: ");
                var flag = int.TryParse(Console.ReadLine(), out int pageno);
                if (flag)
                {
                    pageNo = pageno;
                    break;
                }
                Console.WriteLine("Invalid PageNo. Please try again.");
            }

            while (true)
            {
                Console.Write("Enter pageSize: ");
                var flag = int.TryParse(Console.ReadLine(), out int pagesize);
                if (flag)
                {
                    pageSize = pagesize;
                    break;
                }
                Console.WriteLine("Invalid pageSize. Please try again.");
            }

            var list = await _routeService.GetRoutesAsync(pageNo, pageSize);

            if (list.Routes.Count == 0)
            {
                Console.WriteLine("No routes found.");
            }
            else
            {
                foreach (var route in list.Routes)
                {
                    Console.WriteLine($"Id: {route.Id}");
                    Console.WriteLine($"Route Name: {route.RouteName}");
                    Console.WriteLine($"Origin: {route.Origin}");
                    Console.WriteLine($"Destination: {route.Destination}");
                    Console.WriteLine("-----------------------------------");
                }
            }

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }
    }
}
