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
            //List<Client> ListClient = new List<Client>();
            //GeneratorName.Generator g = new Generator();

            //Client c1 = new Client();
            //c1.DoB = DateTime.Now.AddYears(-60);
            //c1.fullName = g.GenerateDefault(Gender.man);
            //c1.IIN = "123456789123";
            //c1.Login = "Qwerty";
            //c1.Password = "123";
            //c1.PhoneNumber = "87777730111";

            //ListClient.Add(c1);

            //c1.ClientInfoPrint();


            string login = "";
            string pass = "";

            try
            {
                Client client = new Client();
                Service.createClient(ref client);
                client.Login = "admin";
                client.Password = "admin";



                while (!client.isBlocked)
                {
                    Console.Clear();
                    Console.Write("Введите логин:");
                    login = Console.ReadLine();
                    Console.Write("Введите пароль:");
                    pass = Console.ReadLine();

                    if (login != client.Login && pass != client.Password)
                    {
                        client.wrongField++;
                    }
                    else break;

                }

                if (login == client.Login && pass == client.Password)
                {
                    if (client.isBlocked) Console.WriteLine("Ваш акаунт заблокирован!");


                    else
                    {
                        Console.Clear();
                        Console.WriteLine("-----------------<< MENU >>-----------------");
                        Console.WriteLine("1) Список счетов ");
                        Console.WriteLine("2) Создать счет ");
                        Console.WriteLine("3) Пополнить баланс ");

                        int menu = 0;
                        Int32.TryParse(Console.ReadLine(), out menu);

                        if (menu < 1 || menu > 2)
                        {
                            throw new Exception("Invalid choice");
                        }
                        else
                        {
                            switch (menu)
                            {
                                case 1:
                                    {
                                        client.printAccountInfo();


                                    }
                                    break;
                                case 2:
                                    {

                                        Account acc = Service.createAccount();
                                        client.ListAccount.Add(acc);
                                        Console.WriteLine("Счет добавлен успешно!");

                                    }
                                    break;
                                case 3:
                                    {
                                        
                                        Console.WriteLine("введите номер счета: KZ");
                                        string accountNumber = Console.ReadLine();
                                        Console.WriteLine("введите СУММУ: ");
                                        string accountSumm = Console.ReadLine();

                                    }
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ваш акаунт заблокирован!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
