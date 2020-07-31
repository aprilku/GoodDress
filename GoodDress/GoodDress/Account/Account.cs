using System;
using System.Collections.Generic;
using System.Text;
using GoodDress;

namespace GoodDress
{
    class Account
    {
        Account(int Number)
        {
            this.DateTime = new DateTime();
            AccountNumber = Number;
        }

        

        public int AccountNumber { get; set; }
        public DateTime DateTime { get; set; }

        public override string ToString()
        {
            return $"Account Number: {AccountNumber} Order Time: {DateTime}";
        }
        class AccountPart
        {
            public Products Product { get; set; }
            public int Amount { get; set; }
        }
    }


}
