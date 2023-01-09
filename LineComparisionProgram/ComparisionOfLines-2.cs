using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProgram
{
    public  class ComparisionOfLines_2
    {
        public static void Equalsmethod()
        {

            int x1, y1, x2, y2, length1;
            int p, q, r, s, length2;

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
            length1 = (int)Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine("The value of Length1 :{0}", length1);


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



            // Applying Equals Methods
            bool status = length1.Equals(length2);

            if (status == false)
            {
                Console.WriteLine("The given length are not Equal");
            }
            else
            {
                Console.WriteLine("The given length are Equal");
            }

        }
    }
}
