using System;
namespace Constructors
{
    class Company
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" --------Enter Employee Details------- ");
            Console.Write(" Enter Employee Number: ");
            int no = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter Employee Name : ");
            string n = Console.ReadLine();
            Console.Write(" Enter Employee Salary: ");
            double s = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Enter House No: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter House Name: ");
            string hn = Convert.ToString(Console.ReadLine());
            Console.Write(" Enter PinCode:  ");
            int p = Convert.ToInt32(Console.ReadLine());
            Address address = new Address(h,hn,p);
            Employee employee = new Employee(no, n, s, address);
            Console.WriteLine("--------Employee Details--------");
            Console.WriteLine(" Employee No is: "+employee.EmpNo);
            Console.WriteLine(" Employee Name is: "+employee.EmpName);
            Console.WriteLine("Employee Salary is: "+employee.EmpSal);
            Console.WriteLine("Employee Address is: "+employee.EmpAddress);
            Console.ReadLine();
        }
    }
}
