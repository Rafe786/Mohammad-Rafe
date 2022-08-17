using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgranToUpload
{
    class ValueParameterSwap
    {
        static void Swapping(int x, int y)
        {
            Console.WriteLine(x+ "  " + y);
            Console.WriteLine("==========Star Swapping==========");
            int z = x;
            x = y;
            y = z;
            Console.WriteLine(x+ "  " + y);
            Console.WriteLine("==========End Swapping==========");
        }
        static void Main()
        {
            int num1 = 10;
            int num2 = 200;
            Swapping(num1, num2);
            Console.WriteLine(num1+ "  "+ num2);
            Console.ReadLine();
        }
    }
}
