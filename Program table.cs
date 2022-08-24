class Demo
{
    static void cal(int num)
    {
        int ctr = 0;
        bool flag = true;
        while (ctr < num / 2)
        {
            if (num / 2 == 0)
            {
                flag = false;
                break;
            }

            ctr++;
        }

        if (flag == true)
            System.Console.WriteLine("prime");
        else
            System.Console.WriteLine("not prime");
    }
    static void Main()
    {
        System.Console.WriteLine("enter the num");
        int a = int.Parse(System.Console.ReadLine());
        cal(a);
    }



        

}
    