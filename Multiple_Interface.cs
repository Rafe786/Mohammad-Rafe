//Different interface and Same method name......................
using System;
namespace Rafe
{
    interface I1
    {
        void Show();
        void Display();
    }
    interface I2
    {
        void Display();
        void Show();
    }
    class Demo:I1,I2
    {
         void I1.Show()
        {
            Console.WriteLine("Hello Sir");
        }
        void I1.Display()
        {
            Console.WriteLine("Hi Sir");
        }
        void I2.Show()
        {
            Console.WriteLine("Good Morning");
        }
        void I2.Display()
        {
            Console.WriteLine("Good Evening");
        }
        static void Main()
        {
            I1 d = new Demo();
            d.Show();
           
            d.Display();
            I2 d1 = new Demo();
            d1.Show();
            d1.Display();
        }
    }
}
