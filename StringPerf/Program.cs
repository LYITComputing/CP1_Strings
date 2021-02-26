using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPerf
{
    class Program
    {
        static void Main(string[] args)
        {

            //Generate a list
            //List<string> hugeList = Enumerable.Range(1000, 200000).Select(n => n.ToString()).ToList();
            List<string> hugeList = Enumerable.Range(1000, 50000).Select(n => n.ToString()).ToList();

            /*String concatResult = "";
            foreach (String value in hugeList)
            {
                concatResult += value;
            }*/



            
            StringBuilder stringBuilder = new StringBuilder();
            String stringBuilderResult = "";
            foreach (String s in hugeList)
            {
                stringBuilder.Append(s);
            }
 
            stringBuilderResult = stringBuilder.ToString(); 

             

            Console.WriteLine("Finished processing");

        }


    }
}
