using IPB2.OnlineBusSystem.ConsoleApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPB2.OnlineBusSystem.ConsoleApp.Features.Admin.Schdeule
{
    public class ScheduleUI
    {
        private readonly ScheduleService _scheduleService = new ScheduleService();

        public async Task Start()
        {
            await ShowMainMenu();
        }

        public async Task ShowMainMenu()
        {
            while (true)
            {
                Console.WriteLine("\n*** Schedule Menu ***");
                Console.WriteLine("1) Schedule Listing");
                Console.WriteLine("2) Create Schedule");
                Console.WriteLine("3) Upsert Schedule");
                Console.WriteLine("4) Update Schedule");
                Console.WriteLine("5) Delete Schedule");
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
            Console.WriteLine("\n*** Schedule Listing ***");
            int pageNo = ReadInt("Enter pageNo: ");
            int pageSize = ReadInt("Enter pageSize: ");
            Console.WriteLine();

            var response = await _scheduleService.GetScheduleAsync(pageNo, pageSize);

            if (response.Schedules == null || !response.Schedules.Any())
            {
                Console.WriteLine("No schedules found.");
            }
            else
            {
                foreach (var schedule in response.Schedules)
                {
                    Console.WriteLine($"Id: {schedule.Id}");
                    Console.WriteLine($"Bus Id: {schedule.BusId}");
                    Console.WriteLine($"Route Id: {schedule.RouteId}");
                    Console.WriteLine($"Date: {schedule.Date}");
                    Console.WriteLine($"Fare: {schedule.Fare}");
                    Console.WriteLine($"Arrival: {schedule.ArrivalTime}");
                    Console.WriteLine($"Departure: {schedule.DepartureTime}");
                    Console.WriteLine($"Available Seats: {schedule.AvaliableSeat}");
                    Console.WriteLine($"Booked Seats: {schedule.BookSeat}\n---");
                }
            }
        }

        private async Task HandleCreate()
        {
            Console.WriteLine("\n*** Schedule Create ***");
            var request = new UpsertScheduleRequest
            {
                BusId = ReadString("Enter Bus Id: "),
                RouteId = ReadString("Enter Route Id: "),
                Date = ReadDate("Enter Date (yyyy-MM-dd): "),
                Fare = ReadInt("Enter Fare: "),
                ArrivalTime = ReadString("Enter Arrival Time: "),
                DepartureTime = ReadString("Enter Departure Time: ")
            };

            var validation = Validation(request);
            if (!validation.IsSuccess)
            {
                Console.WriteLine($"Validation Error: {validation.Message}");
                return;
            }

            var response = await _scheduleService.CreateAsync(request);
            Console.WriteLine(response.Message);
        }

        private async Task HandleUpsert()
        {
            Console.WriteLine("\n*** Schedule Upsert ***");
            Console.Write("Enter Schedule ID: ");
            var id = Console.ReadLine()!;
            var request = new UpsertScheduleRequest
            {
                BusId = ReadString("Enter Bus Id: "),
                RouteId = ReadString("Enter Route Id: "),
                Date = ReadDate("Enter Date (yyyy-MM-dd): "),
                Fare = ReadInt("Enter Fare: "),
                ArrivalTime = ReadString("Enter Arrival Time (hh:mm): "),
                DepartureTime = ReadString("Enter Departure Time (hh:mm): ")
            };

            var validation = Validation(request);
            if (!validation.IsSuccess)
            {
                Console.WriteLine($"Validation Error: {validation.Message}");
                return;
            }

            var response = await _scheduleService.UpsertAsync(request, id);
            Console.WriteLine(response.Message);
        }

        private async Task HandleUpdate()
        {
            Console.WriteLine("\n*** Schedule Update ***");
            Console.Write("Enter Schedule ID: ");
            var id = Console.ReadLine()!;
            
            // Note: Since UpdateScheduleRequest allows nulls, we use specific logic for Date and Fare
            var request = new UpdateScheduleRequest
            {
                BusId = ReadString("Enter Bus Id (leave empty to skip): "),
                RouteId = ReadString("Enter Route Id (leave empty to skip): "),
                ArrivalTime = ReadString("Enter Arrival Time (leave empty to skip): "),
                DepartureTime = ReadString("Enter Departure Time (leave empty to skip): ")
            };

            Console.Write("Enter Fare (0 to skip): ");
            if (int.TryParse(Console.ReadLine(), out int fare) && fare > 0)
            {
                request.Fare = fare;
            }

            Console.Write("Enter Date (yyyy-MM-dd, leave empty to skip): ");
            var dateStr = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(dateStr) && DateOnly.TryParse(dateStr, out var date))
            {
                request.Date = date;
            }

            var response = await _scheduleService.UpdateAsync(request, id);
            Console.WriteLine(response.Message);
        }

        private async Task HandleDelete()
        {
            Console.WriteLine("\n*** Schedule Delete ***");
            Console.Write("Enter Schedule ID: ");
            var id = Console.ReadLine()!;
            var response = await _scheduleService.DeleteAsync(id);
            Console.WriteLine(response.Message);
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

        private DateOnly ReadDate(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (DateOnly.TryParse(Console.ReadLine(), out var result)) return result;
                Console.WriteLine("Invalid date format. Please use yyyy-MM-dd.");
            }
        }

        private ResponseBaseModel Validation(UpsertScheduleRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.BusId))
                return new ResponseBaseModel { IsSuccess = false, Message = "Bus Id is required." };
            if (string.IsNullOrWhiteSpace(request.RouteId))
                return new ResponseBaseModel { IsSuccess = false, Message = "Route Id is required." };
            if (request.Date == default)
                return new ResponseBaseModel { IsSuccess = false, Message = "Valid date is required." };
            if (request.Fare <= 0)
                return new ResponseBaseModel { IsSuccess = false, Message = "Fare must be greater than zero." };
            if (string.IsNullOrWhiteSpace(request.ArrivalTime))
                return new ResponseBaseModel { IsSuccess = false, Message = "Arrival time is required." };
            if (string.IsNullOrWhiteSpace(request.DepartureTime))
                return new ResponseBaseModel { IsSuccess = false, Message = "Departure time is required." };

            return new ResponseBaseModel { IsSuccess = true, Message = "Validation successful." };
        }
    }
}

