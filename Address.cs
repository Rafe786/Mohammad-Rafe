//Use Getter & Setter...................
using System;
class Address
{
    private int houseNo;
    private string houseName;
    private int pinCode;
    public void SetHouseNo(int houseNo)
    {
        this.houseNo = houseNo;
    }
    public void SetHouseName(string houseName)
    {
        this.houseName = houseName;
    }
    public void SetPinCode(int pinCode)
    {
        this.pinCode = pinCode;
    }
    public int GetHouseNo()
    {
        return houseNo;
    }
    public string GetHouseName()
    {
        return houseName;
    }
    public int GetPinCode()
    {
        return pinCode;
    }
    public override string ToString()
    {
        return houseNo + ",  " + houseName + ",  " + pinCode;
    }
}
