using PageUp.Lib.Infrastructure.Abstractions;
using PageUp.Lib.Models;

namespace PageUp.Lib.Infrastructure.Classes
{
    /// <summary>
    /// Delivery item ,disable to impl base class
    /// </summary>
    public sealed class DeliveryItem : DeliveryBase
    {

        #region props

        public override double Weight { get; set; }

        #endregion

        #region ctors

        public DeliveryItem()
        {
        }

        public DeliveryItem(ProductBox box) : this(box, 0d)
        {
        }

        public DeliveryItem(ProductBox box, double weight) : base(box)
        {
            Weight = weight;
        }

        #endregion

    }
}
