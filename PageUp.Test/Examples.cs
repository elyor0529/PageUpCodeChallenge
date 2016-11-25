using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageUp.Lib.Extensions;
using PageUp.Lib.Infrastructure.Classes;
using PageUp.Lib.Infrastructure.Interfaces;
using PageUp.Lib.Logging;
using PageUp.Lib.Models;

namespace PageUp.Test
{
    [TestClass]
    public class Examples
    { 
        [TestMethod]
        [Description("Reject")]
        public void TestMethod1()
        {
            var delivery = new DeliveryItem(new ProductBox(120, 20, 55), 110);

            delivery.Print();
        }

        [TestMethod]
        [Description("Small Parcel")]
        public void TestMethod2()
        {
            var delivery = new DeliveryItem(new ProductBox(12, 10, 3), 2);

            delivery.Print();
        }

        [TestMethod]
        [Description("Heavy Parcel")]
        public void TestMethod3()
        {
            var delivery = new DeliveryItem(new ProductBox(5, 5, 5), 22);

            delivery.Print();
        }

        [TestMethod]
        [Description("Medium Parcel")]
        public void TestMethod4()
        {
            var delivery = new DeliveryItem(new ProductBox(20, 5, 20), 10);

            delivery.Print();
        }
    }
}
