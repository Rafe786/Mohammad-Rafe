using System;
class Test
{
    public virtual void Show()
    {
        Console.WriteLine("Hello");
    }
}
class Mix : Test
{
    public override void Show()
    {
        Console.WriteLine("Hi");
    }
    static void Main()
    {
        Test t = new Mix();
        t.Show();
    }
}