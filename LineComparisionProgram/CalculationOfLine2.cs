using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProgram
{
    public class CalculationOfLine2
    {
        public static void Line2()
        {
            int p, q, r, s, length2;
            Console.WriteLine("Calculation of 2nd Line length");
            Console.WriteLine("Enter a value for p,q,r,s");
            Console.Write("p :");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("q :");
            q = Convert.ToInt32(Console.ReadLine());
            Console.Write("r :");
            r = Convert.ToInt32(Console.ReadLine());
            Console.Write("s :");
            s = Convert.ToInt32(Console.ReadLine());
            length2 = (int)Math.Sqrt((p - q) ^ 2 + (r - s) ^ 2);
            Console.WriteLine("The value of Length2 :{0}", length2);

        }
    }
}
