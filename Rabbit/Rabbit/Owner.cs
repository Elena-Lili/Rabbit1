using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace Rabbit
{
    class Owner
    {
        private string firstName;
        private string lastName;
        private int ownerCode;
        private string ownerAddress;



        public Owner(string first, string last, int code, string address)
        {
            this.firstName = first;
            this.lastName = last;
            this.ownerCode = code;
            this.ownerAddress = address;
        }
        public string First
        {
            get { return firstName; }
        }
        public string Last
        {
            get { return lastName; }
        }
        public int OwnerCode
        {
            get { return ownerCode; }
        }
        public string OwnerAddress
        {
            get { return OwnerAddress; }
        }

    }
}
