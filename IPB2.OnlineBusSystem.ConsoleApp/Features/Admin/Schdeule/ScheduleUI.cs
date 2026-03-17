using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPB2.OnlineBusSystem.ConsoleApp.Features.Admin.Schdeule
{
    public class ScheduleUI
    {
        public void Start()
        {
            while (true)
            {
                ShowMainMenu();
            }
        }
        public void ShowMainMenu()
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
