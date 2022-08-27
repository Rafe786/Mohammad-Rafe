//Constructor is a special type of Method which is used to initialize an object....... 
using System;
class Test
{
	Test()
	{
		Console.WriteLine("Constructor");
	}
	static void Main()
	{
		Test t= new Test();
	}
}

