class Demo
{
    static void Main()
    {
        int a = 0;
        int b = 1;
        int c;
        System.Console.WriteLine("enter the num ");
        int num = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine(a + "  " + b+" ");
        for (int ctr = 2; ctr < num; ctr++)
        {


            c = a + b;
            System.Console.WriteLine(c);
            a = b;
            b = c;
        }

    }
}
