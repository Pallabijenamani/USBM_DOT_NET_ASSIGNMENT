using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Sum of all odd numbers between user's input range
 * Date - 29/10/2024, language - C#
 */
namespace ConsoleApp1
{
    public class task3
    {
        public void SumOdd()
        {
            int range_start, range_end,sum=0;
            Console.WriteLine("Enter start range");
            range_start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter end range");
            range_end = Convert.ToInt32(Console.ReadLine());
            for (int i = range_start; i < range_end; i++)
            {
                if(i%2 != 0)
                {
                     sum = sum + i;
                }

            }
            Console.WriteLine("Sum of Odd number is  "+sum);
        }
    }
}
