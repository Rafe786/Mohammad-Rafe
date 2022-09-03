//Armstrong Number.........
using System;
namespace Rafe
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Number : ");
            int num = int.Parse(Console.ReadLine());
            int temp, r, sum=0;
            temp = num;
            while(num>0)
            {
                r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;
;            }
            if(temp==sum)
                Console.WriteLine($"Number {temp} is Armstrong");
            else
                Console.WriteLine($"Number {temp} is not Armstrong");
        }
    }
}
