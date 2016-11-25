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
        
        /// <summary>
        /// volume locale field
        /// </summary>
        private readonly int _volume;

        #endregion

        #region ctors

        protected DeliveryBase() : this(new ProductBox())
        {
        }

        protected DeliveryBase(ProductBox box)
        {
            _volume = box.Depth * box.Height * box.Width;
            Box = box;
        }

        #endregion

        #region members

        /// <summary>
        ///     Volume is calculated by Height x Width x Depth
        /// </summary>
        /// <returns></returns>
        public int GetVolume()
        {
            return _volume;
        }

        #endregion

        #region props

        /// <summary>
        /// Cost
        /// </summary>
        public decimal? Cost { get; private set; }

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
                    Cost = null;
                }
                else if ((Weight > 10) && (Weight <= 50))
                {
                    rule = Rules.HeavyParcel;
                    Cost = (decimal?)(15 * Weight);
                }
                else if (_volume < 1500)
                {
                    rule = Rules.SmallParcel;
                    Cost = (decimal?)(0.05 * _volume);
                }
                else if ((_volume >= 1500) && (_volume < 2500))
                {
                    rule = Rules.MediumParcel;
                    Cost = (decimal?)(0.04 * _volume);
                }
                else
                {
                    rule = Rules.LargeParcel;
                    Cost = (decimal?)(0.03 * _volume);
                }

                return rule;
            }
        }

        public virtual ProductBox Box { get; }

        #endregion

    }
}