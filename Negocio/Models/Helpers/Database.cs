using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models.Helpers
{
    class Database
    {
        public static void Synchronize(object origin, object destiny)
        {
            Type originType = origin.GetType();
            PropertyInfo[] properties = originType.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                try
                {
                    PropertyInfo propertyInfo = destiny.GetType().GetProperty(property.Name);
                    propertyInfo.SetValue(destiny, property.GetValue(origin));
                }
                catch { }
            }
        }
    }
}
