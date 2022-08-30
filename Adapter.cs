using System;
namespace Design_Pattern
{
    interface I
    {
        void Show();
        void Display();
        void Process();
        void Sum();
    }
    class  IAdapterclass : I
    {
        public virtual void Show()
        { }
        public virtual void Display()
        { }
        public virtual void Process()
        { }
        public virtual void Sum()
        { }
    }
    class Demo1 :IAdapterclass
    {
        public override void Show()
        {
            Console.WriteLine("Hello Sir");
        }
        public override void Display()
        {
            Console.WriteLine("Good Morning");
        }
        static void Main()
        {
            IAdapterclass d = new Demo1();
            d.Show();
            d.Display();
        }
    }
}
