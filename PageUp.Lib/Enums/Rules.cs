using System.ComponentModel;

namespace PageUp.Lib.Enums
{
    /// <summary>
    /// Rules
    /// </summary>
    public enum Rules
    {
        [Description("Reject")]
        Reject = 1,

        [Description("Heavy Parcel")]
        HeavyParcel = 2,

        [Description("Small Parcel")]
        SmallParcel = 3,

        [Description("Medium Parcel")]
        MediumParcel = 4,

        [Description("Large Parcel")]
        LargeParcel = 5
    }
}
