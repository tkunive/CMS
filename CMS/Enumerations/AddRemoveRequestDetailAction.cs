using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Enumerations
{
    public enum AddRemoveRequestDetailAction
    {
        [Description("Add to Agreement")]
        Add = 1,
        [Description("Active on Agreement")]
        Remove = 2
    }
    public static class EnumExtensions
    {
        public static string Description(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length == 0 ? value.ToString() : ((DescriptionAttribute)attributes[0]).Description;
        }

        public static AddRemoveRequestDetailAction ReturnAddRemoveRequestDetailActionEnum(this string str)
        {

            if (string.Equals(str, "Add to Agreement", StringComparison.OrdinalIgnoreCase)) { return AddRemoveRequestDetailAction.Add; }
            else { return AddRemoveRequestDetailAction.Remove; }

        }

    }
}
