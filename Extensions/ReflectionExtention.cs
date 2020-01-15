using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Memberships.Extensions
{
    public static class ReflectionExtention
    {
        public static string GetPropertyValue<T>(this T item, string propertyname)
        {
            return item.GetType()
                .GetProperty(propertyname)
                .GetValue(item, null).ToString();
        }
    }
}