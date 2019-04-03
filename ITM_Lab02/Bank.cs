using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITM_Lab02
{
    class Bank
    {

        public string BankName { get; set; }
        public string BankAddress { get; set; }

        public List<Account> Accounts { get; set; }

        public Bank(string name, string address)

        {
            BankName = name;
            BankAddress = address;
            Accounts = new List<Account>();
        }

        public void CreatAccount(string accountName, string accoutAddress, string iBan)
        {
            var account = new Account(accountName, accoutAddress, iBan);
            Accounts.Add(account);
        }

        public Account GetAccount(string iBan)
        {
            foreach (var item in Accounts)
            {
                if (item.Iban == iBan)
                {
                    return item;
                }
                
            }
            return null;
        }
    }
}
