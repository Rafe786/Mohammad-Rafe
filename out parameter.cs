class Demo
{
   
    static void Main()
    {
        bool e, o;
        Check(6, out e, out o);
        System.Console.WriteLine(e);
        System.Console.WriteLine(o);

    }
    static bool Check(int x, out bool even, out bool odd)
    {
        even = false;
        odd = true;
        if (x / 2 == 0)
            even=true;
        
        
        else if (x / 2 != 0)
            odd = false;
    }
}