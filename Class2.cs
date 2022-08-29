using System;
namespace Abstract
{
    abstract class Test3
    {
        public Test3()
        {
            Console.WriteLine("Test");
        }
    }
    class Demo3 : Test3
    {
        static void Main()
        {
            Test3 d = new Demo3();      //Can't create abstrac class's object...
        }
    }
}
