using Energistics.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Energistics.DataAccess
{
   public static  class EnumExtension 
    {
        public static string XMLName<T>(this T @enum ) where T : struct, IComparable
        {
            var exenum = new ExtensibleEnum<T>(@enum);
            return exenum.ToString();
        }
    }
}
