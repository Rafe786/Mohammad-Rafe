using System;
class Bank
{
	private string bankName;
	private string branchName;
	private BankAddress bankAddress;
	private BankCustomer bankCustomer;
	public Bank(string bankName, string branchName, BankAddress bankAddress, BankCustomer bankCustomer)
	{
		this.bankName=bankName;
		this.branchName=branchName;
		this.bankAddress=bankAddress;
		this.bankCustomer=bankCustomer;
	}
	public string BankName
	{
	get{
		return bankName;
	}
	}
	public string BranchName
	{
		get{
			return branchName;
		}
	}
	public BankAddress BankAddress
	{
		get{
			return bankAddress;
		}
	}
	public BankCustomer BankCustomer
	{
		get{
			return bankCustomer;
		}
	}
}
class BankAddress
{
	private string bankLocation;
	private int pinCode;
	public BankAddress()
	{
		this.bankLocation=bankLocation;
		this.pinCode=pinCode;
	}
	public string BankLocation
	{
		get{
			return bankLocation;
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
		return  "Mirzapur" + ", " + 221307;
	}
}
class BankCustomer
{
	private string customerName;
	private int accountNo;
    private CustomerAddress customerAddress;
	public BankCustomer(CustomerAddress customerAddress)
	{
		this.customerName=customerName;
		this.accountNo=accountNo;
		this.customerAddress=customerAddress;
	}
	public string CustomerName
	{
		get{
			return customerName;
		}
	}
	public int AccountNo
	{
		get{
			return accountNo;
		}
	}
	public CustomerAddress CustomerAddress
	{
		get{
			return customerAddress;
		}
	}
	public override string ToString()
	{
		return "Mohammad Rafe" + "  " + "A/C No.: " + " " + 12300000000000123456;
	}
}	
class CustomerAddress
{
	private string homeName;
	private int homeNo;
	private int pinCode2;
	public CustomerAddress()
	{
		this.homeName=homeName;
		this.homeNo=homeNo;
		this.pinCode2=pinCode2;
	}
	public string HomeName
	{
		get{
			return homeName;
		}
	}
	public int HomeNo
	{
		get{
			return homeNo;
		}
	}
	public int PinCode2
	{
		get{
			return pinCode2;
		}
	}
	public override string ToString()
	{
		return "R Villa" + ",  " + 92 + ",  " + 221306;
	}
}
class Demo
{
	static void Main()
	{
		BankAddress bankaddress=new BankAddress();
		CustomerAddress customeraddress=new CustomerAddress();
		BankCustomer bankcustomer=new BankCustomer(customeraddress);
		
		Bank bank=new Bank("BOB" , "Mirzapur", bankaddress, bankcustomer);
		Console.WriteLine("..................................................................");
		Console.WriteLine("..............................Bank Details........................");
		Console.WriteLine("Bank Name: "  + bank.BankName);
		Console.WriteLine("Branch Name: " + bank.BranchName);
		Console.WriteLine("Bank Address : " + bank.BankAddress);
		Console.WriteLine("......................Customer Details............................");
		Console.WriteLine("Customer Name : " + bank.BankCustomer);
		Console.WriteLine("Customer Address : " + bankcustomer.CustomerAddress);
	}
}
