using System;
namespace ConsoleApp5
{
    class Demo
    {
        static void Main()
        {
            string name = "ADDRESS";
            string str = " ";
            int length = 0;
            length = name.Length - 1;
            while (length >= 0)
            {
                str = str + name[length];
                length--;
            }
            Console.WriteLine(str);
        }
    }
}