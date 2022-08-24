using System;
namespace n1
{
    class Parent
    {
        public void property()
        {
            Console.WriteLine("father property");
        }
        protected virtual  void marry()
        {
            Console.WriteLine(" father choice"); ;

        }
    }
    class Child : Parent
    {
        protected override void marry()
        {
            Console.WriteLine(" choice is my");
        }
        static void Main()
        {
            Child c = new Child();
            c.marry();
            Console.ReadLine();
        }
    }
}
