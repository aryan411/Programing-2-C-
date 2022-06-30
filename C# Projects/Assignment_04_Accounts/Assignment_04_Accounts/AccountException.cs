using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts
{
    class AccountException : Exception
    {
        public AccountException(ExceptionEnum reason)
            : base(reason.ToString()) { }
    }
}
