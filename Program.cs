using System;
namespace Abstract
{
    abstract class Test
    {
        public void Show()
        {
            Console.WriteLine("Hello");
        }
    }
    class Demo : Test
    {
        static void Main()
        {
            Test t = new Demo();   //Can't create abstrac class's object...
            t.Show();             
        }
    }
}
