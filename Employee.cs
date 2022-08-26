//Use Getter & Setter...................
using System;
namespace ConsoleApp4
{
    class Employee
    {
        private int empNo;
        private string empName;
        private double empSal;
        private Address empAddress;
        public void SetEmpNo(int empNo)
        {
            this.empNo = empNo;
        }
        public void SetEmpName(string empName)
        {
            this.empName = empName;
        }
        public void SetEmpSal(double empSal)
        {
            this.empSal = empSal;
        }
        public void SetEmpAddress( Address empAddress)
        {
            this.empAddress = empAddress;
        }
        public int GetEmpNo()
        {
            return empNo;
        }
        public string GetEmpName()
        {
            return empName;
        }
        public double GetEmpSal()
        {
            return empSal;
        }
        public Address GetEmpAddress()
        {
            return empAddress;
        }
    }
}
