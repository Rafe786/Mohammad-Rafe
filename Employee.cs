using System;
class Address
{
   private int  houseNo;
   private string  houseName;
   private int pinCode;
  public int  HouseNo
  {
    set
   {
     houseNo =value;
   }
    get
     {
     return houseNo ;
     }
  }
     public  string HouseName
     {
      set
      {
       houseName = value;
    }
   get
    {
     return houseName;
    
     }
    }
    public int PinCode
    {
     set
      {
       pinCode = value;
       }
      get
       {
        return pinCode;
       }
   }
   public override string ToString()
  {
	return houseNo +  ",  " + houseName + ",  " + pinCode;
  }
}

class Employee
{
	private int empNo;
  	private string empName;
	private double empSal;
    private Address empAddress;
	public int EmpNo
	{
	set
	{
	  empNo=value;
	}
	get
	{
	  return empNo;
	}
    }
	public string EmpName
	{
	set
	{
	  empName=value;
	}
	get
	{
	  return empName;
	}
    }
	public double EmpSal
	{
	set
	{
	  empSal=value;
	}
	get 
	{
	  return empSal;
	}
    }
     public Address EmpAddress
     {
       set
      {
       empAddress=value;
       }
     get
       {
         return empAddress;
       }
	 }
}
class Chetu
{
static void Main()
{
	Employee employee=new Employee();
        employee.EmpNo = 1421;
        employee.EmpName= "Dinesh";
        employee.EmpSal = 2340.99;
        
   
	Address address = new Address();
   address.HouseNo =12;
   address.HouseName= "Sharda Bhawan";
   address.PinCode = 121;
   employee.EmpAddress = address;
      
Console.WriteLine(".................");
Console.WriteLine(".......EmployeeDatile......");
Console.WriteLine(employee.EmpNo);
Console.WriteLine(employee.EmpName);
Console.WriteLine(employee.EmpSal);
Console.WriteLine("............");
Console.WriteLine("Address is : " + employee.EmpAddress);
}
}


