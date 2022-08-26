using System;
namespace Rafe
{
    class Employee
    {
        private int empNo;
        private string empName;
        private double empSal;
        private Address empAddress;
        public Employee(int empNo, string empName, double empSal, Address empAddress)
        {
            this.empNo = empNo;
            this.empName = empName;
            this.empSal = empSal;
            this.empAddress = empAddress;
        }
        public int EmpNo
        {
            get
            {
                return empNo;
            }
        }
        public string EmpName
        {
            get
            {
                return empName;
            }
        }
        public double EmpSal
        {
            get
            {
                return empSal;
            }
        }
        public Address EmpAddress
        {
            get
            {
                return empAddress;
            }
        }
    }
}
