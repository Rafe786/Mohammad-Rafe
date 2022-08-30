//Prototype Design Pattern.................

using System;
class Test
{
    private Test()
    {

    }
    public void Show()
    {
        Console.WriteLine("Hello" + " " + this.GetHashCode());
    }
    public static Test GetTestObject()
    {
        Test test = new Test();
        return test;
    }
}
class Demo
{
    static void Main()
    {
        Test t = Test.GetTestObject();
        t.Show();
        Test t2 = Test.GetTestObject();
        t2.Show();
    }
}