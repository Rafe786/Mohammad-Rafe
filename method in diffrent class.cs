class Demo
{
    void pattern(int num)
    {
        int ctr = 2;
        bool flag = true;
        while (ctr < num/ 2)
        {
            if (num% 2 == 0)
                flag = false;
            break;
          
        }
        ctr++;

        if (flag == true)
            System.Console.WriteLine("prime");
        else
            System.Console.WriteLine("not prime");
    }
    static void Main()
    {
        System.Console.Write("enter the number");
        int num = int.Parse(System.Console.ReadLine());
        Demo d = new Demo(); 
       d.pattern(num);
       

    }
}
      




