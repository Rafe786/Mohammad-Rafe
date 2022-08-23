using System;
class Demo
{
    public int num = 1000;
}
class Test : Demo
{
    Test()         //Using Constructor.......................
   {
    num = 200;
   }
    static void Main()
    {
        Demo d = new Demo();
        Test t = new Test();
        Console.WriteLine(t.num);
        Console.WriteLine(d.num);
        Console.ReadLine();
    }
}