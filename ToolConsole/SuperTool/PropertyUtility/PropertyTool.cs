using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SuperTool.PropertyUtility
{
    public class PropertyTool
    {
        public static void SetNullStringPropertyToEmpty<T>(T t) where T : class
        {
            Type type = typeof(T);
            var stringProperties = type.GetProperties().Where(o => o.PropertyType == typeof(string));
            foreach (PropertyInfo propertyInfo in stringProperties)
            {
                if (propertyInfo.GetValue(t) == null)
                {
                    propertyInfo.SetValue(t, string.Empty);
                }
            }
        }
    }
}
