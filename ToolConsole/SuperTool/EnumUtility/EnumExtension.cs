using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SuperTool.EnumUtility
{
    public static class EnumExtension
    {
        public static string GetDescription(this Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());

            DescriptionAttribute descriptionAttribute = fieldInfo?.GetCustomAttribute(typeof(DescriptionAttribute), false) as DescriptionAttribute;

            return descriptionAttribute == null ? "" : descriptionAttribute.Description;
        }

        public static bool Contains(this Enum values, Enum checkValue)
        {
            if (values.GetType() != checkValue.GetType())
            {
                throw new ArgumentException("Can not compare two different enum.");
            }

            if (!Attribute.IsDefined(values.GetType(), typeof(FlagsAttribute)))
            {
                throw new ArgumentException("Please add Flags attribute.");
            }

            var enumStringCollection = values.ToString().Split(',').Select(o => o.Trim());

            return enumStringCollection.Contains(checkValue.ToString());
        }
    }

}
