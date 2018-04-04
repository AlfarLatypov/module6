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
            ListAccount = new List<Account>();
        }

        private string fullName_;
        public string fullName
        {

            get { return fullName_; }

            set { fullName_ = value; }


        }

        private string IIN_;
        public string IIN
        {
            get { return IIN_; }
            set
            {
                if (value.Length == 12) IIN_ = value;
                else throw new Exception("\nError! Некорректно введен ИИН!");
            }
        }

        public DateTime DoB { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        private int wrongField_;
        public bool isBlocked { get; set; } = false;
        public int wrongField
        {
            get { return wrongField_; }
            set {
                if (value >= 3) isBlocked = true;
                wrongField_ = value;
            }

        }



        public List<Account> ListAccount;


        public void ClientInfoPrint()
        {
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n", fullName, IIN, Login, Password, DoB, PhoneNumber);
        }


        public void printAccountInfo()
        {
            double sumBalance = 0;
            foreach (Account item in ListAccount)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("AccountNumber: {0}", item.AccountNumber);
                Console.WriteLine("Balance: {0}", item.Balance);
                Console.WriteLine("Create Date: {0}", item.CreateDate);
                Console.WriteLine("Close Date: {0}", item.CloseDate);
                //Console.WriteLine("---------------------------------------");
                sumBalance += item.Balance;
            }
            Console.WriteLine("---------------------------------------\n ИТОГО : {0:n0}", sumBalance);


        }



    }
}
