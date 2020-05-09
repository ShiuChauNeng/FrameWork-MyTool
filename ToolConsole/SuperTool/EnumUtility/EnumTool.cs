using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SuperTool.EnumUtility
{
    public static class EnumTool
    {
        public static T GetValueFromDescription<T>(string description) where T : struct
        {
            #region Contract

            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("Only can Convert to enum type.");
            }

            #endregion

            foreach (var fieldInfo in typeof(T).GetFields())
            {
                DescriptionAttribute attribute = fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute), false) as DescriptionAttribute;
                if (attribute != null)
                {
                    if (attribute.Description == description)
                    {
                        return (T)fieldInfo.GetRawConstantValue();
                    }
                }
            }

            throw new ArgumentException("Can not find any same description in enum.");
        }
    }
}
