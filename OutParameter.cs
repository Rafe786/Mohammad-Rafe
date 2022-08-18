using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgranToUpload
{
    class OutParameter
    {
        static void Cal(int x, int y, out int sum, out int minus, out int mul, out int div)
        {
            sum = x + y;
            minus = x - y;
            mul = x * y;
            div = x / y;
        }
        static void Main()
        {
            int s, mi, mu, d;
            Cal(20, 10, out s, out mi, out mu, out d);
            Console.WriteLine("Sum is : " + s);
            Console.WriteLine("Minus is : " + mi );
            Console.WriteLine("Multi is : " + mu);
            Console.WriteLine("Div is : " + d);
            Console.ReadLine();
        }
    }
}
