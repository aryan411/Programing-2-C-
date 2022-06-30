using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts
{
    class LoginEventArgs : EventArgs
    {
        public string PersonName { get; }
        public bool Success { get; }
        public LoginEventArgs(string name, bool success) : base()
        {
            this.PersonName = name;
            this.Success = success;
        }
    }
}
