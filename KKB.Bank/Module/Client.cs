using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKB.Bank.Module
{
    public class Client

    {

        public Client()
        {
            ListAccount = new  List<Account>();
    }

        private string fullName_;
        public string fullName {

            get { return fullName_; }
            
            set { fullName_ = value.Replace("", "") }


        }

        private string IIN_;
        public string IIN { get { return IIN_; }
            set {
                if (value.Length == 12) IIN = value;
                else throw new Exception("\nError! Некорректно введен ИИН!");
            }
        }

        public DateTime DoB { get; set; }

        public string Login { get; set; }
        public string Password { private get; set; }
        public string PhoneNumber { get; set; }

        List<Account> ListAccount;


        public void ClientInfoPrint()
        {
            Console.WriteLine();
        }

    }
}
