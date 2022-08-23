using System;
class Demo1
{
    public int num = 100;
}
class Test2 : Demo1
{
   new public int num=200; //Data Hiding
        static void Main1()
    {
        Test2 t = new Test2();
        Console.WriteLine(t.num);
        Console.ReadLine();
    }
}