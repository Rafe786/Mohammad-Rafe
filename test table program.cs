class Demo
{
    static void table(int num)
    {
        int i = 1;
        while (i <= 10)
        {
            System.Console.WriteLine(num + "*" + i + "="num * i);
            i++;
        }
    }
    static void Main()
    {
        System.Console.WriteLine("enter the num");
        int a = int.Parse(System.Console.ReadLine());
        table(a);
    } 
}