using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i =0; i< 128; i++)
            {
                Console.Write(Convert.ToChar(i) + "\t");
                if (i % 6 == 0)
                    Console.WriteLine("\n");
            }
        }
    }
}
