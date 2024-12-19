using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

/* 
 * Even and Odd between 1 to 50
 * Date - 29/10/2024, language - C#
 */

namespace ConsoleApp1
{
    public class task1
    {
        public void EvenOdd()
        {
            int range_start, range_end;
            Console.WriteLine("Enter the start rang");
            range_start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the end range");
            range_end = Convert.ToInt32(Console.ReadLine());
            for (int i = range_start, j = range_end; i < j; i++)
            {
              if(i%2 == 0)
                {
                    Console.WriteLine("even "+i);
                }
                else
                {
                    Console.WriteLine("                        odd  " + i);
                }
            }
        }
    }
}
