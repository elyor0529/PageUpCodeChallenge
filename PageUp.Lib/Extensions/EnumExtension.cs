using System;
using System.ComponentModel;
using System.Linq;

namespace PageUp.Lib.Extensions
{
    public static class EnumExtension
    {
        /// <summary>
        /// Get enum descrption 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetDescription(this Enum value)
        {
            if (value == null)
                return String.Empty;

            var attribute = value.GetType()
                .GetField(value.ToString())
                .GetCustomAttributes(typeof(DescriptionAttribute), false)
                .SingleOrDefault() as DescriptionAttribute;

            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
