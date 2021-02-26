using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("U+0061 LATIN SMALL LETTER a            ");
            PrintProperties('a');
            PrintProperties('È');

            
        }

        public static void PrintProperties(char c)
        {
            Console.Write(" {0, -3}", c);
            Console.Write(" {0, -5}", CharUnicodeInfo.GetNumericValue(c));
            Console.Write(" {0, -5}", CharUnicodeInfo.GetDigitValue(c));
            Console.Write(" {0, -5}", CharUnicodeInfo.GetDecimalDigitValue(c));
            Console.Write(" {0}", CharUnicodeInfo.GetUnicodeCategory(c));

        }
    }
}
