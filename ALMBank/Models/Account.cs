using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALMBank.Models
{
    public class Account
    {
        public int Balance { get; set; }
        public string AccountName { get; set; }
        public Customer Customer{ get; set; }
    }
}
