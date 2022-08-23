//"new" keyword used to hide a method, property, indexer,or event of base class into derived class.
//"new" keyword is an optional.

using System;
class Grand
{
    protected void Marry()
    {
        Console.WriteLine("Grand Choice");
    }
}
class Parent_1:Grand
{
    protected virtual new void Marry()      
    {
        Console.WriteLine("Parent Choice");
    }
}
class Child_1 : Parent_1
{
    protected override void Marry()
    {
        Console.WriteLine("Child Choice");
    }
    static void Main2()
    {
        Child_1 c = new Child_1();
        c.Marry();
     
    }
}
