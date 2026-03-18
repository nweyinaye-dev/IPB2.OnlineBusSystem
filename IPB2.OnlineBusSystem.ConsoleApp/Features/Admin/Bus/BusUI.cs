using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPB2.OnlineBusSystem.ConsoleApp.Features.Admin.Bus
{
    public class BusUI
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
            Console.WriteLine("\n*** Bus Menu ***");
            Console.WriteLine("1) Bus Listing");
            Console.WriteLine("2) Create Bus");
            Console.WriteLine("3) Update Bus");
            Console.WriteLine("4) Delete Bus");
            Console.Write("Please choose option: ");
            var choose = Console.ReadLine();
            bool isFlag = int.TryParse(choose, out int res);
        }


    }
}
