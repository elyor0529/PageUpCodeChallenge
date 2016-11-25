using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PageUp.Lib;
using PageUp.Lib.Extensions;
using PageUp.Lib.Infrastructure.Classes;
using PageUp.Lib.Logging;
using PageUp.Lib.Models;

namespace PageUp.Demo
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {

                Console.Write("Enter Weight in kg: ");
                var weight = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(weight))
                {
                    Console.Clear();
                    continue;
                }

                Console.Write("Enter Height in cm: ");
                var height = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(height))
                {
                    Console.Clear();
                    continue;
                }

                Console.Write("Enter Width in cm: ");
                var width = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(width))
                {
                    Console.Clear();
                    continue;
                }

                Console.Write("Enter Depth: ");
                var depth = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(depth))
                {
                    Console.Clear();
                    continue;
                }

                Console.WriteLine("-------------------------");

                var box = new ProductBox(depth.ChangeType<int>(), height.ChangeType<int>(), width.ChangeType<int>());
                var delivery = new DeliveryItem(box, weight.ChangeType<double>());

                delivery.Print();

                Console.ReadKey();
                Console.Clear();
                Thread.Sleep(1000);
            }

        }
    }
}
