using System;
using PageUp.Lib.Extensions;
using PageUp.Lib.Infrastructure.Interfaces;

namespace PageUp.Lib.Logging
{
    public static class LogExtensions
    {
        /// <summary>
        /// Print result
        /// </summary>
        /// <param name="delivery"></param>
        public static void Print(this IDelivery delivery)
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
    }
}
