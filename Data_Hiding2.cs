class Demo3
{
    public static int num = 100;
}
class Test1 : Demo3
{
    new public static int num = 200;   //Data Hiding .........

    static void Main2()
    { 
        System.Console.WriteLine(num);
        System.Console.WriteLine(Demo3.num);
        System.Console.ReadLine();
    }
}