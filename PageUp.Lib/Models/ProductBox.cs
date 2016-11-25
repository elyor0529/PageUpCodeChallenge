namespace PageUp.Lib.Models
{
    /// <summary>
    /// The user inputs are:
    ///   Weight(kg)
    ///   Height(cm)
    ///   Width(cm)
    ///   Depth(cm)
    /// </summary>
    public class ProductBox
    {
        
        #region props

        /// <summary>
        /// Weight(kg)
        /// </summary>
        public int Depth { get; set; }

        /// <summary>
        /// Height(cm)
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Width(cm)
        /// </summary>
        public int Width { get; set; }

        #endregion

        #region ctors

        public ProductBox()
        {

        }

        public ProductBox(int depth, int height, int width)
        {
            Depth = depth;
            Height = height;
            Width = width;
        }

        #endregion

    }
}
