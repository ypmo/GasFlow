using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords
{
    public static class EnumExtensions
    {
        public static TAttr GetEnumAttribute<TEnum, TAttr>(this TEnum  value)  
        {
            //https://stackoverflow.com/questions/5097766/how-to-get-custom-attribute-values-for-enums
            MemberInfo memberInfo = typeof(TEnum).GetMember(value.ToString())
                                             .FirstOrDefault();

            if (memberInfo != null)
            {
                TAttr attribute = (TAttr)
                             memberInfo.GetCustomAttributes(typeof(TAttr), false)
                                       .FirstOrDefault();
                return attribute;
            }

            return default;
        }
    }
}
