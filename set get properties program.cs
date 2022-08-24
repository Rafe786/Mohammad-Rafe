using System;
class Test
{
    private string  empNo;
    private int carNo;
    public string  EmpName
    {
        set
        {
            empNo = value;

        }
        get
        {
            return empNo;
        }

    }
    public int CarNo
    {
        set
        {
            carNo = value;

        }
        get
        {
            return carNo;
        }
    }
   
    
}
class Chetu
{
    static void Main()
    {
        Test test = new Test();
        Console.WriteLine(" enter the employee");
        string  a = (Console.ReadLine());
        test.EmpName = a;
        Console.WriteLine(" enter the carno");
        int b = Convert.ToInt32(Console.ReadLine());
        test.CarNo= b;
        Console.WriteLine("employee name " +test.EmpName);
        Console.WriteLine("car no" + test.CarNo);

    }
} 