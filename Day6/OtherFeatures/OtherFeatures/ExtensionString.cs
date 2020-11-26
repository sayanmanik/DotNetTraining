using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherFeatures
{
    public static class ExtensionString
    {
        public static int ConvertToInt(this string val)
        {
            return Convert.ToInt32(val);
        }
    }
}
