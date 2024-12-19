using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Positive Negetive , even positive or negetive, odd positive or negetive
 * 
 */
namespace ConsoleApp1
{
    public class task5
    {
        public void CheckEO()
        {
            int num;
            Console.WriteLine("Input your number");
            num = Convert.ToInt32(Console.ReadLine());

            // string result = num > 0 ? num % 2 == 0 ? Console.Write("Even positive") : Console.Write("Odd positive") : num < 0 ? num % 2 == 0 ? Console.Write("Even Negetive") : Console.Write("Odd negetive") ;

            if (num >= 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("This is even Positive");
                }
                else
                {
                    Console.WriteLine("Odd Positive");
                }
            }
            else if (num <= 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("This is an even negetive number ");
                }
                else
                {
                    Console.WriteLine("This is an odd negetive number");
                }
            }
            else if (num == 0)
            {
                Console.WriteLine("This is zero");
            }
            else
            {
                Console.WriteLine("This is Wrong input");
            }


        }
    }
}