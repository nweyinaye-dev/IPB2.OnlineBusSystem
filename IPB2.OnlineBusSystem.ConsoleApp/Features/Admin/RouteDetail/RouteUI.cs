using Azure.Core;
using IPB2.OnlineBusSystem.ConsoleApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IPB2.OnlineBusSystem.ConsoleApp.Features.Admin.RouteDetail
{
    public class RouteUI
    {
        RouteService _routeService = new RouteService();
        public async Task Start() 
        {
            await ShowMainMenu(); 
        }
        public async Task ShowMainMenu()
        {
            while (true)
            {
                Console.WriteLine("\n*** Route Menu ***");
                Console.WriteLine("1) Route Listing");
                Console.WriteLine("2) Create Route");
                Console.WriteLine("3) Upsert Route");
                Console.WriteLine("4) Update Route");
                Console.WriteLine("5) Delete Route");
                Console.WriteLine("6) Exit");
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
                        await HandleListing();break;
                    case 2:
                        await HandleCreate(); break;
                    case 3:
                        await HandleUpsert(); break;
                    case 4:
                        await HandleUpdate(); break;
                    case 5:
                        await HandleDelete(); break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
        private async Task HandleListing()
        {
            Console.WriteLine("\n*** Route Listing ***");
            int pageNo = ReadInt("Enter pageNo: ",true);
            int pageSize = ReadInt("Enter pageSize: ",true);
            Console.WriteLine();

            var list = await _routeService.GetRoutesAsync(pageNo, pageSize);

            if (!list.Routes.Any())
                Console.WriteLine("No routes found.");
            else
            {
                foreach (var route in list.Routes)
                {
                    Console.WriteLine($"Id: {route.Id}");
                    Console.WriteLine($"Route Name: {route.RouteName}");
                    Console.WriteLine($"Origin: {route.Origin}");
                    Console.WriteLine($"Destination: {route.Destination}\n---");
                }
            }
                
        }
        private async Task HandleCreate()
        {
            Console.WriteLine("\n*** Route Create ***");
            var request = new UpsertRouteRequest
            {
                RouteName = ReadString("Enter Route Name: "),
                Origin = ReadString("Enter Origin: "),
                Destination = ReadString("Enter Destination: ")
            };

            var validation = Validation(request);
            if (!validation.IsSuccess)
            {
                Console.WriteLine($"Validation Error: {validation.Message}");
                return;
            }

            var response = await _routeService.CreateAsync(request);
            Console.WriteLine(response.ToString()) ;
        }
        private async Task HandleUpsert()
        {
            Console.WriteLine("\n*** Route Upsert ***");
            Console.Write("Enter Rourt ID: ");
            var id = Console.ReadLine()!;
            var request = new UpsertRouteRequest
            {
                RouteName = ReadString("Enter Route Name: "),
                Origin = ReadString("Enter Origin: "),
                Destination = ReadString("Enter Destination: ")
            };

            var validation = Validation(request);
            if (!validation.IsSuccess)
            {
                Console.WriteLine($"Validation Error: {validation.Message}");
                return;
            }

            var response = await _routeService.UpsertAsync(request, id);
            Console.WriteLine(response.ToString());
        }
        private async Task HandleUpdate()
        {
            Console.WriteLine("\n*** Route Update ***");
            Console.Write("Enter Rourt ID: ");
            var id = Console.ReadLine()!;
            var request = new UpdateRouteRequest
            {
                RouteName = ReadString("Enter Route Name: "),
                Origin = ReadString("Enter Origin: "),
                Destination = ReadString("Enter Destination: ")
            };
          
            var response = await _routeService.UpdateAsync(request, id);
            Console.WriteLine(response.ToString());
        }
        private async Task HandleDelete()
        {
            Console.WriteLine("\n*** Route Delete ***");
            Console.Write("Enter Rourt ID: ");
            var id = Console.ReadLine()!;
            var response = await _routeService.DeleteAsync(id);
            Console.WriteLine(response.ToString());
        }
        private int ReadInt(string prompt, bool isRequired = true)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine()?.Trim();

                // Handle empty input
                if (string.IsNullOrEmpty(input))
                {
                    if (isRequired)
                    {
                        Console.WriteLine("This field is required.");
                        continue;
                    }
                    return 0;
                }

                if (int.TryParse(input, out int result))
                {
                    return result;
                }

                Console.WriteLine("Invalid number. Please enter a valid integer.");
            }
        }
        private string ReadString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine()?.Trim() ?? string.Empty;
        }
        private ResponseBaseModel Validation(UpsertRouteRequest request)
        {
            // Require Validation
            if (string.IsNullOrWhiteSpace(request.RouteName))
                return new ResponseBaseModel { IsSuccess = false, Message = "Route name is required." };
            if (string.IsNullOrWhiteSpace(request.Origin))
                return new ResponseBaseModel { IsSuccess = false, Message = "Origin no is required." };
            if (string.IsNullOrWhiteSpace(request.Destination))
                return new ResponseBaseModel { IsSuccess = false, Message = "Destination is required." };

            return new ResponseBaseModel { IsSuccess = true, Message = "Validatin successfully." };

        }


    }
}
