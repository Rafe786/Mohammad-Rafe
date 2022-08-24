using System;
class Demo
{
    static void Main()
    {
        int ctr = 1;
        while (ctr <= 5 )
        {
            int ptr = 5;
            while (ptr >=ctr)
            {
                Console.Write((char)(70 - ptr));
                ptr--;
            }
            Console.WriteLine();
            ctr++;
        }
    }
}

