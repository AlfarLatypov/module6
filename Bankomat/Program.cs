using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KKB.Bank.Module;
using GeneratorName;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> ListClient = new List<Client>();
            GeneratorName.Generator g = new Generator();

            Client c1 = new Client();
            c1.DoB = DateTime.Now.AddYears(-60);
            c1.fullName = g.GenerateDefault(Gender.man);
            c1.IIN = "123456789123";
            c1.Login = "Qwerty";
            c1.Password = "123";
            c1.PhoneNumber = "87777730111";

            ListClient.Add(c1);

        }
    }
}
