using PageUp.Lib.Enums;
using PageUp.Lib.Models;

namespace PageUp.Lib.Infrastructure.Interfaces
{
    /// <summary>
    /// Delivery interface
    /// </summary>
    public interface IDelivery
    {

        /// <summary>
        /// Product box
        /// </summary>
        ProductBox Box { get; }

        /// <summary>
        /// Product volume
        /// </summary>
        /// <returns></returns>
        int GetVolume();

        /// <summary>
        /// Delivery Rule
        /// </summary>
        Rules? Rule { get; }

        /// <summary>
        /// Delivery cost
        /// </summary>
        decimal? Cost { get; }

        /// <summary>
        /// Product weight
        /// </summary>
        double Weight { get; set; }
    }
}
