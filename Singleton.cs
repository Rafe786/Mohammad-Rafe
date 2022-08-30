using System;
namespace Design_Pattern
{
   class Test
    {
        private Test()
        { }
        private static Test test;
        public void Show()
        {
            Console.WriteLine("Hello"+ " " + this.GetHashCode());
        }
        public static Test GetTestObject()
        {
            if(test==null)
            {
                test = new Test();
            }
            return test;
        }
    }
    class Demo
    {
        static void Main()
        {
            Test t = Test.GetTestObject();
            t.Show();
            Test t1 = Test.GetTestObject();
            t1.Show();
        }
    }
}
