using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafe
{
    class Address
    {
        private int houseNo;
        private string houseName;
        private int pinCode;
        public Address(int houseNo, string houseName, int pinCode)
        {
            this.houseNo = houseNo;
            this.houseName = houseName;
            this.pinCode = pinCode;
        }
        public int HouseNo
        {
            get
            {
                return houseNo;
            }
        }
        public string HouseName
        {
            get
            {
                return houseName;
            }
        }
        public int PinCode
        {
            get
            {
                return pinCode;
            }
        }
    }
}
