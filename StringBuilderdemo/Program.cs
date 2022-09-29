using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
                StringBuilder sb = new StringBuilder("Hello to everyone ");
                // Append  , AppendFormat  , Insert  , Remove , Replace
               
                Console.WriteLine(sb);

                sb.Append(" Good evening to all  ");
                Console.WriteLine(sb);

                sb.AppendFormat(" my salary is {0:C}", 5000);
                Console.WriteLine(sb);

            sb.Replace("Good", "Very Good");
            Console.WriteLine(sb);

            sb.Insert(0, "hello! ");
            Console.WriteLine(sb);

            sb.Remove(7, 5);
            Console.WriteLine(sb);

        }


    }
    }
