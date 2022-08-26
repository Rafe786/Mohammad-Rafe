//Use Getter & Setter...................
using System;
namespace ConsoleApp4
{
    class Chetu
    {
        static void Main()
        {
            Console.Write("Enter The Employee Number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter The Employee Name : ");
            string ename = Console.ReadLine();
            Console.Write("Enter The Employee Salery : ");
            double sal = Convert.ToDouble(Console.ReadLine());
            Employee employee= new Employee();
            employee.SetEmpNo(num);
            employee.SetEmpName(ename);
            employee.SetEmpSal(sal);
            Console.WriteLine("............................................");

            Console.Write("Enter The House Number: ");
            int no = int.Parse(Console.ReadLine());
            Console.Write("Enter The House Name : ");
            string hname = Console.ReadLine();
            Console.Write("Enter The PinCode : ");
            int pin = int.Parse(Console.ReadLine());

            Address address = new Address();
            address.SetHouseNo(no);
            address.SetHouseName(hname);
            address.SetPinCode(pin);
           employee.SetEmpAddress(address);
            
            Console.WriteLine("..............................................");
            Console.WriteLine("................Employee Datials..............");
            Console.WriteLine("No is : " + employee.GetEmpNo());
            Console.WriteLine("Name is : " + employee.GetEmpName());
            Console.WriteLine("Salery is : " + employee.GetEmpSal());
            Console.WriteLine("..............................................");

            Console.WriteLine("Address is: " + employee.GetEmpAddress());
        }
    }
}
