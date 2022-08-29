using System;
namespace Abstract
{
    abstract class Test1
    {
        public abstract void Display();         //We can create bodyless method in abstract class this is called abstract method
    }
    class Demo1 : Test1
    {
        public override void Display()
        {
            Console.WriteLine("Hello Sir!");
        }
        static void Main()         
        {
            Test1 t = new Demo1();      //Can't create abstrac class's object...
            t.Display();
        }
    }
}
