using PageUp.Lib.Enums;
using PageUp.Lib.Infrastructure.Interfaces;
using PageUp.Lib.Models;

namespace PageUp.Lib.Infrastructure.Abstractions
{
    /// <summary>
    /// Delivery base abstraction class
    /// </summary>
    public abstract class DeliveryBase : IDelivery
    {

        #region fields

        private decimal? _cost;
        #endregion

        #region ctors

        protected DeliveryBase() : this(new ProductBox())
        {
        }

        protected DeliveryBase(ProductBox box)
        {
            Volume = box.Depth * box.Height * box.Width;
            Box = box;
        }

        #endregion

        #region members

        /// <summary>
        ///     Volume is calculated by Height x Width x Depth
        /// </summary>
        /// <returns></returns>
        public int Volume { get; }

        #endregion

        #region props

        /// <summary>
        /// Cost
        /// </summary>

        public decimal? GetCost()
        {
            return _cost;
        }

        /// <summary>
        /// Weight
        /// </summary>
        public abstract double Weight { get; set; }

        /// <summary>
        /// The rule matched with the highest priority should be used to calculate the cost of delivery
        /// </summary>
        public Rules? Rule
        {
            get
            {
                Rules? rule;

                if (Weight > 50)
                {
                    rule = Rules.Reject;
                    _cost = null;
                }
                else if (Weight > 10 && Weight <= 50)
                {
                    rule = Rules.HeavyParcel;
                    _cost = (decimal?)(15 * Weight);
                }
                else if (Volume < 1500)
                {
                    rule = Rules.SmallParcel;
                    _cost = (decimal?)(0.05 * Volume);
                }
                else if (Volume >= 1500 && Volume < 2500)
                {
                    rule = Rules.MediumParcel;
                    _cost = (decimal?)(0.04 * Volume);
                }
                else
                {
                    rule = Rules.LargeParcel;
                    _cost = (decimal?)(0.03 * Volume);
                }

                return rule;
            }
        }

        public virtual ProductBox Box { get; set; }

        #endregion

    }
}