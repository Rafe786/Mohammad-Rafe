using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafe
{
    class Decimal_To_Binary
    {
        static void Main()
        {
            Console.Write("Enter the Decimal Number to Convert in Binary Number : ");
            int num = int.Parse(Console.ReadLine());
            int i;
            int[] arr = new int[100];
            for (i = 0; num > 0; i++)
            {
                arr[i] = num % 2;
                num = num / 2;
            }
            for (i = i-1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }
    }
}
