using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageUp.Lib.Extensions;
using PageUp.Lib.Infrastructure.Classes;
using PageUp.Lib.Infrastructure.Interfaces;
using PageUp.Lib.Models;

namespace PageUp.Test
{
    [TestClass]
    public class Examples
    {
        /// <summary>
        /// Print result
        /// </summary>
        /// <param name="delivery"></param>
        private static void PrintResult(IDelivery delivery)
        {

            var rule = delivery.Rule.GetDescription();
            var cost = delivery.GetCost();

            Console.WriteLine("Category: {0}", rule);
            if (cost != null)
            {
                Console.WriteLine("Cost: ${0}", cost);
            }
            else
            {
                Console.WriteLine("Cost: N/A");
            }
        }

        [TestMethod]
        [Description("Reject")]
        public void TestMethod1()
        {
            var delivery = new DeliveryItem(new ProductBox(120, 20, 55), 110);

            PrintResult(delivery);
        }

        [TestMethod]
        [Description("Small Parcel")]
        public void TestMethod2()
        {
            var delivery = new DeliveryItem(new ProductBox(12, 10, 3), 2);

            PrintResult(delivery);
        }

        [TestMethod]
        [Description("Heavy Parcel")]
        public void TestMethod3()
        {
            var delivery = new DeliveryItem(new ProductBox(5, 5, 5), 22);

            PrintResult(delivery);
        }

        [TestMethod]
        [Description("Medium Parcel")]
        public void TestMethod4()
        {
            var delivery = new DeliveryItem(new ProductBox(20, 5, 20), 10);

            PrintResult(delivery);
        }
    }
}
