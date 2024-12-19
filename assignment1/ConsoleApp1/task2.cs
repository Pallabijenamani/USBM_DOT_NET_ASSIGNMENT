using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
/*
 * Square and Queue in a range input by user
 * Date - 29 / 10 / 2024, language - C#

 */
namespace ConsoleApp1
{
    public class task2
    {
        public void SquareQueue() {
            int range_start, range_end;
            Console.WriteLine("Enter the start range");
            range_start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the end range");
            range_end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number      Square     Cube");

            for (int i = range_start; i <= range_end; i++)
            {
               float square = MathF.Pow(i, 2);
                float cube = MathF.Pow(i, 3);
                Console.WriteLine(i     +"          "+square+"      "+cube);
            }
        }
    }
}
