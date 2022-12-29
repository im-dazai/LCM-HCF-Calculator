using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCM_HCF_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, a, b, Bucket, LCM, HCF;

            // Taking Input in first number
            Console.WriteLine("Enter First Number :");
            n1 = Convert.ToInt32(Console.ReadLine());


            // Taking Input in Second Number
            Console.WriteLine("Enter Second Number :");
            n2 = Convert.ToInt32(Console.ReadLine());

            // Making equal to fake ints to use in and outside of loop.
            a = n1;
            b = n2;

            // if b is not 0 then move value of b to Bucket, then make b equal to (a % b)
            // then move value of a to Bucket
            while (b != 0)
            {
                Bucket = b;
                b = a % b;
                a = Bucket;


            }

            // Now a has the value of HCF for both n1 and n2
            HCF = a;

            // Now LCM has the value of LCM of both n1 and n2
            LCM = (n1 * n2) / HCF;

            /* Printing the results */

            // For LCM
            Console.WriteLine("LCM of " + n1 + " and " + n2 + " is " + LCM);

            // For HCF
            Console.WriteLine("HCF of " + n1 + " and " + n2 + " is " + HCF);

           




            // Taking Input in first number

            //int n, a, b, c, d;
            //n = 2;
            //Console.WriteLine("Enter Number to Divide");
            //a = Convert.ToInt32(Console.ReadLine()) ;
            //b = n;
            //while (b <= 5)
            //{
            //    a = a / n;
            //    Console.WriteLine(a);

            //    d = n;
            //    Console.Write(d);
            //    Console.WriteLine(" is the Divisor.");


            //    b++;
            //}




           

            



            Console.ReadLine();
        }
    }
}
