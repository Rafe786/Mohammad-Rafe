using System;
namespace n1
{
    class Parent
    {
        protected virtual void loop()
        {
            Console.WriteLine("father property");
        }
        protected virtual void Marry()
        {
            Console.WriteLine(" father choice"); 

        }
    }
   
    class Child2 : Parent
    {
        protected override void loop()
        {
            base.loop();
            Console.WriteLine("don");
        } 
        protected override void Marry()
        {
            base.Marry();
           
            Console.WriteLine("sarthak");
        }

        static void Main()
        {
          
            Child2 c2 = new Child2();
           
            c2.Marry();
            c2.loop();
           
        }
    }
}
