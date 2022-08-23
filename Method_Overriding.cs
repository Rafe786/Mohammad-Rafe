using System;
class Parent
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
class Child:Parent
{
    protected override void Marry()
    {
        Console.WriteLine("Child Choice");
    }
    static void Main()
    {
        Child child = new Child();
        child.Property();
        child.Marry();
        Console.ReadLine();
    }
}
