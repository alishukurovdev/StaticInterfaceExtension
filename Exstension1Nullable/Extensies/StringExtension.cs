using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exstension1Nullable.Extensies
{
    static class StringExtension
    {
        public static string ToCaptalize(this string txt)
        {
             return txt.Substring(0,1).ToUpper() + txt.Substring(1).ToLower();
           // return Char.ToUpper(txt[0]) + txt.Substring(1).ToLower();
        }
    }
}
