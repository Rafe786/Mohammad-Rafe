//"new" keyword is used to hide a method, property, indexer,or event of base class into derived class.
//"new" keyword is an optional.
using System;
class Parent11
{
    protected static void Marry()
    {
        Console.WriteLine("Father Choice");
    }
}
class Child:Parent11
{
    protected static new void Marry()
    {
        Console.WriteLine("Children................ Choice");
    }
    static void Main5()
    {
        //Child c = new Child();
        Marry();
        Console.ReadLine();
    }
}