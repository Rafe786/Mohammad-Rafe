using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgranToUpload
{
    class RefParameterSwap
    {
        static void SwapValue(ref int x, ref int y)
        {
            Console.WriteLine(x+ "  "+ y);
            Console.WriteLine("------------------Start Swapping------------------");
            int z = x;
            x = y;
            y = z;
            Console.WriteLine(x+ "  " + y);
            Console.WriteLine("------------------End Swapping---------------------");
        }
        static void Main()
        {
            int num1 = 1;
            int num2 = 500;
           
            SwapValue(ref num1, ref num2);
            Console.WriteLine(num1 + "  " + num2);
            Console.ReadLine();
        }
    }
}
