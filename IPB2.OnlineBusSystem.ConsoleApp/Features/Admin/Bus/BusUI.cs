using IPB2.OnlineBusSystem.ConsoleApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPB2.OnlineBusSystem.ConsoleApp.Features.Admin.Bus
{
    public class BusUI
    {
        private readonly BusService _busService = new BusService();
        public async Task Start()
        {
            await ShowMainMenu();
        }
        public async Task ShowMainMenu()
        {
            while (true)
            {
                Console.WriteLine("\n*** Bus Menu ***");
                Console.WriteLine("1) Bus Listing");
                Console.WriteLine("2) Create Bus");
                Console.WriteLine("3) Upsert Bus");
                Console.WriteLine("4) Update Bus");
                Console.WriteLine("5) Delete Bus");
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
                        await HandleListing();
                        break;
                    case 2:
                        await HandleCreate();
                        break;
                    case 3:
                        await HandleUpsert();
                        break;
                    case 4:
                        await HandleUpdate();
                        break;
                    case 5:
                        await HandleDelete();
                        break;
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
            Console.WriteLine("\n*** Bus Listing ***");
            int pageNo = ReadInt("Enter pageNo: ");
            int pageSize = ReadInt("Enter pageSize: ");
            Console.WriteLine();

            var response = await _busService.GetBusAsync(pageNo, pageSize);

            if (response.Buss == null || !response.Buss.Any())
            {
                Console.WriteLine("No buses found.");
            }
            else
            {
                foreach (var bus in response.Buss)
                {
                    Console.WriteLine($"Id: {bus.Id}");
                    Console.WriteLine($"Bus No: {bus.BusNo}");
                    Console.WriteLine($"Bus Name: {bus.BusName}");
                    Console.WriteLine($"Bus Type: {bus.BusType}");
                    Console.WriteLine($"Total Seats: {bus.TotalSeat}\n---");
                }
            }
        }
        private async Task HandleCreate()
        {
            Console.WriteLine("\n*** Bus Create ***");
            var request = new UpsertBusRequest
            {
                BusNo = ReadString("Enter Bus No: "),
                BusName = ReadString("Enter Bus Name: "),
                BusType = ReadString("Enter Bus Type: "),
                TotalSeat = ReadInt("Enter Total Seats: ")
            };

            var validation = Validation(request);
            if (!validation.IsSuccess)
            {
                Console.WriteLine($"Validation Error: {validation.Message}");
                return;
            }

            var response = await _busService.CreateAsync(request);
            Console.WriteLine(response.ToString());
        }
        private async Task HandleUpsert()
        {
            Console.WriteLine("\n*** Bus Upsert ***");
            Console.Write("Enter Bus ID: ");
            var id = Console.ReadLine()!;
            var request = new UpsertBusRequest
            {
                BusNo = ReadString("Enter Bus No: "),
                BusName = ReadString("Enter Bus Name: "),
                BusType = ReadString("Enter Bus Type: "),
                TotalSeat = ReadInt("Enter Total Seats: ")
            };

            var validation = Validation(request);
            if (!validation.IsSuccess)
            {
                Console.WriteLine($"Validation Error: {validation.Message}");
                return;
            }

            var response = await _busService.UpsertAsync(request, id);
            Console.WriteLine(response.ToString());
        }
        private async Task HandleUpdate()
        {
            Console.WriteLine("\n*** Bus Update ***");
            Console.Write("Enter Bus ID: ");
            var id = Console.ReadLine()!;
            var request = new UpdateBusRequest
            {
                BusNo = ReadString("Enter Bus No  (leave empty to skip): "),
                BusName = ReadString("Enter Bus Name  (leave empty to skip): "),
                BusType = ReadString("Enter Bus Type  (leave empty to skip): ")
            };

            Console.Write("Enter Total Seats  (leave 0 to skip): ");
            if (int.TryParse(Console.ReadLine(), out int TotalSeat) && TotalSeat > 0)
            {
                request.TotalSeat = TotalSeat;
            }

            var response = await _busService.UpdateAsync(request, id);
            Console.WriteLine(response.ToString());
        }
        private async Task HandleDelete()
        {
            Console.WriteLine("\n*** Bus Delete ***");
            Console.Write("Enter Bus ID: ");
            var id = Console.ReadLine()!;
            var response = await _busService.DeleteAsync(id);
            Console.WriteLine(response.ToString());
        }
        private int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int result)) return result;
                Console.WriteLine("Invalid number.");
            }
        }
        private string ReadString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine()?.Trim() ?? string.Empty;
        }
        private ResponseBaseModel Validation(UpsertBusRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.BusNo))
                return new ResponseBaseModel { IsSuccess = false, Message = "Bus number is required." };
            if (string.IsNullOrWhiteSpace(request.BusName))
                return new ResponseBaseModel { IsSuccess = false, Message = "Bus name is required." };
            if (string.IsNullOrWhiteSpace(request.BusType))
                return new ResponseBaseModel { IsSuccess = false, Message = "Bus type is required." };
            if (request.TotalSeat <= 0)
                return new ResponseBaseModel { IsSuccess = false, Message = "Total Seat must be at leave 20 seats." };

            return new ResponseBaseModel { IsSuccess = true, Message = "Validation successful." };
        }
    }
}

