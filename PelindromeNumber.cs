using System;
namespace ConsoleApp2
{
    class PelindromeNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Number : ");
            int num = int.Parse(Console.ReadLine());
            int res, temp, sum = 0;
            temp = num;
            while (num > 0)
            {
                res = num % 10;                
                sum = sum * 10 + res;
                num = num / 10;
            }
            if (temp == sum)
                Console.WriteLine($"{temp} is Pelindrome Number");
            else
                Console.WriteLine($"{temp} is Not Pelindrome Number ");
        }
    }
}
