using System;
namespace Rafe
{
    class Chetu
    {
        static void Main()
        {
            Address address = new Address(12, "R Villa", 221306);
            Console.WriteLine("House Number: " + address.HouseNo);
            Console.WriteLine("House Name: " + address.HouseName);
            Console.WriteLine("PinCode : " + address.PinCode);
            Console.WriteLine(".............................................................");

            Employee employee = new Employee(22, "Rafe", 2135632.30, Address);
            Console.WriteLine("Employee No:"+ employee.EmpNo);
            Console.WriteLine("Employee Name: " + employee.EmpName);
            Console.WriteLine("Employee Salery: " + employee.EmpSal);
            Console.WriteLine("Employee Address:" + employee.EmpAddress);
            Console.ReadLine();
        }
    }
}
