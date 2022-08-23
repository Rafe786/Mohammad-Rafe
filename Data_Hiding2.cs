class Demo
{
    public static int num = 100;
}
class Test : Demo
{
    new public static int num = 200;   //Data Hiding .........

    static void Main()
    { 
        System.Console.WriteLine(num);
        System.Console.WriteLine(Demo.num);
        System.Console.ReadLine();
    }
}
