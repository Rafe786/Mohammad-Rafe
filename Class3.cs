using System;
namespace Abstract
{
  abstract class Test4
    {
        public abstract void M1();
        public abstract void M2();
    }
    abstract class Demo4:Test4
    {
        public override void M1()
        {
            Console.WriteLine("Hi");
            
        }
        class process : Demo4
        {
            public override void M2()
            {
                Console.WriteLine("Hello");
            }
            static void Main()
            {
                Test4 t = new process();
                t.M1();
                t.M2();
            }
        }
    }
}
