using System;
class Parent1
{
    protected void Property()
    {
        Console.WriteLine("1230000 Cash |  10000KG Gold  |  Land in Sector 18 Noida  |  BMW Car");
    }
    protected virtual void Marry()
    {
        Console.WriteLine("Father Choice");
    }
}
class Child21:Parent1
{
    protected override void Marry()
    {
        Console.WriteLine("Child Choice");
    }
    static void Main1()
    {
        Child21 child = new Child21();
        child.Property();
        child.Marry();
        Console.ReadLine();
    }
}