using System;
using System.Collections.Generic;
using System.Text;

namespace BitMEXFormulas.Common
{
    public class Account
    {
        public decimal WalletBalance { set; get; }

        public decimal MarginBalance { set; get; }

        public decimal AvailableBalance { set; get; }
    }
}
