using System;
namespace sarthak
{
    class Employee
    {
        private int empNo;
        private string empName;
        private double empSal;

        public void SetEmpNo(int eno)
        {
            empNo = eno;

        }
        public void SetEmpName(string ename)
        {
            empName = ename;

        }
        public void SetEmpSal(double esal)
        {
            empSal = esal;

        }
        public int GetEmpNo()
        {
            return empNo;

        }
        public string GetEmpName()
        {
            return empName;

        }
        public Double GetEmpsal()
        {
            return empSal;

        }
    }
}