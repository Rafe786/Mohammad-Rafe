class Demo
{
    static void fab()
    {
        int c;
        int a = 0;
        int b = 1;
        System.Console.WriteLine("enter the number");
        int number = int.Parse(System.Console.ReadLine());
        for (int i = 2; i <= number; i++)
        {
            c = a + b;
            System.Console.WriteLine(c + "  ");
            a = b;
            b = c;
        }

    }
    static void Main()

    {
        fab();
    }


}               
               
                     

     