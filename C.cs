using System;
class Bank
{
	private string bankName;
	private string branchName;
	private Address bankAddress;
	private Customer bankCustomer;
	public Bank(string bankName, string branchName, Address bankAddress, Customer bankCustomer)
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
	public Address BankAddress
	{
		get{
			return bankAddress;
		}
	}
	public Customer BankCustomer
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
		this.BankLocation=bankLocation;
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
		return  Mirzapur + ", " + 221307;
	}
}
class BankCustomer
{
	private string customerName;
	private int accountNo;
    private Address2 customerAddress;
	public BankCustomer(string customerName, int accountNo, Address2 customerAddress)
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
	public Address2 CustomerAddress
	{
		get{
			return customerAddress;
		}
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
	static void Mani()
	{
		BankAddress address=new BankAddress();
		CustomerAddress address2=new CustomerAddress();
		BankCustomer customer=new BankCustomer("Mohammad Rafe", 00000000000123456,  address2);
		
		Bank bank=new Bank("BOB" , Mirzapur, address, customer);
		Console.WriteLine("..................................................................");
		Console.WriteLine("..............................Bank Details........................");
		Console.WriteLine("Bank Name: "  + bank.BankName);
		Console.WriteLine("Branch Name: " + bank.BranchName);
		Console.WriteLine("Bank Address : " + bank.BankAddress);
		Console.WriteLine("Costomer Details : " + bank.BankCustomer);
		Console.WriteLine(bank.CustomerAddress);
	}
}
