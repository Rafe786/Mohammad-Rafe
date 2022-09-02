using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ReverseNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter The Number ");
            int num = int.Parse(Console.ReadLine());
            int r, reverse = 0;
            while(num!=0)
            {
                r = num % 10;
                reverse = reverse * 10 + r;
                num = num / 10;
            }
                Console.WriteLine("Reverse Number is : " + reverse);
            
        }
    }
}
