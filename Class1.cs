using System;
class Parent
{
    protected virtual void Marry()
    {
        Console.WriteLine("Father Choice");
    }
}
class Child1:Parent
{
    protected override void Marry()
    {
        base.Marry();
        Console.WriteLine("After 3 Years");
    }
    static void Main()
    {
        Child1 c = new Child1();
        c.Marry();
        Console.ReadLine();
    }
}