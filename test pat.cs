class Demo
{
    static void pat()
    {
        int ctr = 0;
        while (ctr < 3)
        {
            int ptr = 0;
            while (ptr <= ctr)
            {
                System.Console.Write("A");
                ptr++;
            }
            System.Console.WriteLine();
            ctr++;
        }
    }
    static void Main()
    {
        pat();
    }
} 
