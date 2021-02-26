using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class Program
    {
        public int Num { get; set; }
        public string Str { get; set; }

        static void Main(string[] args)
        {
            Program a = new Program() { Num = 1, Str = "Hi" };
            Program b = new Program() { Num = 1, Str = "Hi" };

            if (a == b)
            {
                Console.WriteLine("They are the same");
            }
            if (a.Str == b.Str)
            {
                Console.WriteLine("the objects strings are the same");
            }



            if (System.Object.Equals(a,b))
            {
                Console.WriteLine("They are the same");
            }

            if(System.Object.ReferenceEquals(a,b))
            {
                Console.WriteLine("They are the same");
            }

            a = b;
            if (a == b)
            {
                Console.WriteLine("They are the same");
            }
            if (System.Object.Equals(a, b))
            {
                Console.WriteLine("They are the same");
            }

            if (System.Object.ReferenceEquals(a, b))
            {
                Console.WriteLine("They are the same");
            }


            
            ////st1 += st2;
            //string str3 = Concatstrings(st1, st2);

            //Console.WriteLine(st1);

            //Stringbuilder - System.Text
            //StringBuilder sb = new StringBuilder("ABC");

            ////Append
            //sb.Append(new char[] { 'D', 'E', 'F' });

            ////Display the number of characters
            //Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());

            //sb.Append("This is some new text that should result in a reallocation and some more memory");
            //Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());

        }
        public static string Concatstrings(string stringone, string stringtwo)
        {
            return stringone + stringtwo;
        }

    }
}
