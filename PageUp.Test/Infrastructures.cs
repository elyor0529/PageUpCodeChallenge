using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageUp.Lib.Infrastructure.Classes;
using PageUp.Lib.Models;

namespace PageUp.Test
{
    [TestClass]
    public class Infrastructures
    {
        [TestMethod]
        [Description("Empty product")]
        public void TestMethod1()
        {
            new ProductBox();
        }

        [TestMethod]
        [Description("Fill product")]
        public void TestMethod2()
        {
            new ProductBox(0, 0, 0);
        }

        [TestMethod]
        [Description("Empty delivery")]
        public void TestMethod3()
        {
            new DeliveryItem();
        }

        [TestMethod]
        [Description("Fill delivery without weight")]
        public void TestMethod4()
        {
            new DeliveryItem(new ProductBox());
        }

        [TestMethod]
        [Description("Fill delivery include weight")]
        public void TestMethod5()
        {
            new DeliveryItem(new ProductBox(0, 0, 0), 0);
        }
    }
}
