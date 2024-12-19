using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Compare two string
 * Date - 29 / 10 / 2024, language - C#
 * 
 */
namespace ConsoleApp1
{
    public class task4
    {

        public void CompareString()
        {
            String str1, str2;
            Console.WriteLine("Enter the first string");
            str1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter second string");
            str2 = Convert.ToString(Console.ReadLine());
            if (str1 == str2)
            {
                Console.WriteLine("The strings are equal");

            }
            else
            {
                Console.WriteLine("The strings are unequal"); 
            }
        }
    }
}