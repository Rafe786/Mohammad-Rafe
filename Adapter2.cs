using System;
namespace Design_Pattern
{
    interface I1
    {
        void Show();
        void Display();
        void Process();
        void Sum();
    }
    class I1Adapterclass : I1
    {
        public  void Show()
        { }
        public  void Display()
        { }
        public  void Process()
        { }
        public  void Sum()
        { }
    }
    class Demo2 : IAdapterclass
    {
        public new void Show()
        {
            Console.WriteLine("Hi Sir");
        }
        public new void Display()
        {
            Console.WriteLine("Good Evening");
        }
        static void Main()
        {
            Demo2 d = new Demo2();
            d.Show();
            d.Display();

        }
    }
}
