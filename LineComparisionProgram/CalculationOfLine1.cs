using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProgram
{
    public class CalculationOfLine1
    {
        public static void Line1()
        {
            int x1, y1, x2, y2, length1; 
             
            Console.WriteLine("Calculation of 1st Linelength");
            Console.WriteLine("Enter a value for x1,y1,x2,y2");
            Console.Write("x1 :");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1 :");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2 :");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2 :");
            y2 = Convert.ToInt32(Console.ReadLine());
            length1 =(int)Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine("The value of Length1 :{0}", length1);

        }
    }
}
