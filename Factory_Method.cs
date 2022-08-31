using System;
class Factory
{
    private Factory()
    { }
    public void Show()
    {
        Console.WriteLine("Hello");
    }
    public static Factory GetFactoryObject()
    {
        Factory factory = new Factory();
        return factory;
    }
}
class Demo10
{
    static void Main()
    {
        Factory f = Factory.GetFactoryObject();
        f.Show();
    }
}
