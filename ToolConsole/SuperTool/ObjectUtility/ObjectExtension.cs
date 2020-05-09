using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SuperTool.ObjectUtility
{
    public static class ObjectExtension
    {
        public static void SetNullStringPropertyToEmpty(this object content)
        {
            Type type = content.GetType();
            if (type.IsClass)
            {
                var stringProperties = type.GetProperties().Where(o => o.PropertyType == typeof(string));
                foreach (PropertyInfo propertyInfo in stringProperties)
                {
                    if (propertyInfo.GetValue(content) == null)
                    {
                        propertyInfo.SetValue(content, string.Empty);
                    }
                }
            }
        }

        public static bool IsNull(this object obj)
        {
            return obj == null;
        }
    }
}
