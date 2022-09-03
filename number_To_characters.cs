using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafe
{
    class number_To_characters
    {
        static void Main3()
        {
            Console.Write("Enter The Numbers : ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0, r;
            while (num > 0)
            {
                r = num % 10;
                sum = sum * 10 + r;
                num = num / 10;
            }
            num = sum;
            while(num>0)
            {
                r = num % 10;
                switch (r)
                {
                    case 0:
                        Console.Write("Zero");
                        break;
                    case 1:
                        Console.Write("One");
                        break;
                    case 2:
                        Console.Write("Two");
                        break;
                    case 3:
                        Console.Write("Three");
                        break;
                    case 4:
                        Console.Write("Four");
                        break;
                    case 5:
                        Console.Write("Five");
                        break;
                    case 6:
                        Console.Write("Six");
                        break;
                    case 7:
                        Console.Write("Seven");
                        break;
                    case 8:
                        Console.Write("Eight");
                        break;
                    case 9:
                        Console.Write("Nine");
                        break;                
                    default:
                        Console.Write("Invalid");
                        break;
                       
                }
                num = num / 10;
                              
            }
            
        }
    }
}
