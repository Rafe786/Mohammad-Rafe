using System;
class Employee
	{
		private string empName;
		private int empNo;
		private double empSal;
		private Address empAddress;
		public Employee(string empName, int empNo, double empSal, Address empAddress)
		{
			this.empName=empName;
			this.empNo=empNo;
			this.empSal=empSal;
			this.empAddress=empAddress;
		}
		public string EmpName
		{
			get{
				return empName;
			}
		}
		public int EmpNo
		{
			get{
				return empNo;
			}
		}
		public double  EmpSal
		{
			get{
				return empSal;
			}
		}
		public Address EmpAddress{
			get{
				return empAddress;
			}
		}
	}


class Address
{
	private string houseName;
	private int houseNo;
	private int pinCode;
	public Address()
	{
		this.houseName=houseName;
		this.houseNo=houseNo;
		this.pinCode=pinCode;
	}
	public string HouseName
	{
		get{
			return houseName;
		}
	}
	public int HouseNo
	{
		get{
			return houseNo;
		}
	}
	public int PinCode
	{
		get{
			return pinCode;
		}
	}
	public override string ToString()
	{
		return "R Villa" + ", " + 21 + ", " + 213301;
	}
}
class Company
{
	static void Main()
	{
		Address address=new Address();
		Employee employee=new Employee("Rafe", 21, 2136.20, address);
		
		Console.WriteLine("..................................................");
		Console.WriteLine(".................Employee Details.................");
		Console.WriteLine("Employee Name : " + employee.EmpName);
		Console.WriteLine("Employee Number : " + employee.EmpNo);
		Console.WriteLine("Employee Salery : " + employee.EmpSal);
		Console.WriteLine("Employee Address : " + employee.EmpAddress);
	}
}

			