using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PageUp.Lib;
using PageUp.Lib.Extensions;
using PageUp.Lib.Infrastructure.Classes;
using PageUp.Lib.Models;

namespace PageUp.Demo
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {

                Console.Write("Enter Weight in kg:");
                var weight = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(weight))
                {
                    Console.Clear();
                    continue;
                }

                Console.Write("Enter Height in cm:");
                var height = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(height))
                {
                    Console.Clear();
                    continue;
                }

                Console.Write("Enter Width in cm:");
                var width = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(width))
                {
                    Console.Clear();
                    continue;
                }

                Console.Write("Enter Depth:");
                var depth = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(depth))
                {
                    Console.Clear();
                    continue;
                }

                Console.WriteLine("-------------------------");

                var box = new ProductBox(depth.ChangeType<int>(), height.ChangeType<int>(), width.ChangeType<int>());
                var delivery = new DeliveryItem(box);

                Console.WriteLine("Category:{0}", delivery.Rule.GetDescription());
                Console.WriteLine("Cost:{0:C0}", delivery.GetVolume());

                var returnKey = Console.ReadKey();
                if (returnKey.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    continue;
                }

                //wait 10 sek
                Thread.Sleep(10 * 1000);
            }

        }
    }
}
