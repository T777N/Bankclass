using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



#region Task 1


//namespace Bank_Class
//{

//    class Client
//    {
//        static public int static_ID { get; set; }
//        public int Id { get; set; }//prob Tab Tab
//        public string Name { get; set; }
//        public string Surname { get; set; }
//        public int Age { get; set; }
//        public double Salary { get; set; }
//        public BankCart bankCart { get; set; }

//        Client()
//        {
//            Id = 0;
//            Name = string.Empty;
//            Surname = string.Empty;
//            Age = 0;
//            Salary = 0;
//            bankCart = default;
//        }

//        public Client(string name, string surname, int age, double salary, BankCart bankCart)
//        {
//            ++static_ID;
//            Id = static_ID;
//            Name = name;
//            Surname = surname;
//            Age = age;
//            Salary = salary;
//            this.bankCart = bankCart;
//        }

//        public void Show_Client()
//        {
//            Console.WriteLine($" ID : {Id} ");
//            Console.WriteLine($" Name : {Name} ");
//            Console.WriteLine($" Surname : {Surname} ");
//            Console.WriteLine($" Age : {Age} ");
//            Console.WriteLine($" Salary : {Salary} + M");
//            Console.WriteLine(" + + + + + + + + + + + + + + + + + ");
//            bankCart.Show_BankKart();
//        }
//    }
//    class BankCart
//    {

//        public string Bankname { get; set; }
//        public string Username { get; set; }
//        public string PAN { get; set; }
//        public string PIN { get; set; }

//        public string CVC { get; set; }
//        public DateTime ExpireDate { get; set; }
//        public int Balance_ { get; set; }


//        public BankCart()
//        {
//            Bankname = string.Empty;
//            Username = string.Empty;
//            PAN = string.Empty;
//            PIN = string.Empty;
//            CVC = string.Empty;
//            ExpireDate = DateTime.Now;
//            Balance_ = 0;
//        }
//        public BankCart(string bankname, string username, string pAN, string pIN, string cVC)
//        { 
//            Bankname = bankname;
//            Username = username;
//            PAN = pAN;
//            PIN = pIN;
//            CVC = cVC;
//            ExpireDate = DateTime.Now;

//        }
//        public int Balans()
//        {
//            Random ran = new Random();
//            int random_number = ran.Next(100, 4500);
//            Balance_ = random_number;

//            return Balance_;
//        }
//        public void Show_BankKart()
//        {
//            Console.WriteLine($" Bankname : {Bankname} ");
//            Console.WriteLine($" Username : {Username} ");
//            Console.WriteLine($" PAN : {PAN} ");
//            Console.WriteLine($" PIN : {PIN} ");
//            Console.WriteLine($" CVC : {CVC} ");
//            Console.WriteLine($" ExpireDate : {ExpireDate} ");
//            Console.WriteLine($" Balans : {Balans()} ");
//        }
//    }
//    class Bank
//    {
//        public Client[] Clients { get; set; }
//        public int ClientCount { get; set; }
//        public void AddClients(Client client)
//        {

//            var temp = new Client[++ClientCount];
//            if (Clients != null)
//            {
//                Clients.CopyTo(temp, 0);
//            }
//            temp[temp.Length - 1] = client;
//            Clients = temp;
//        }
//        public void DeleteClients_withID(int id)
//        {
//            for (int i = 0; i < Clients.Length; i++)
//            {
//                if (Clients[i].Id == id)
//                {
//                    Clients[i] = null;
//                    break;
//                }
//            }
//        }
//        public void ShowCartBalance(string pin,string pan)
//        {
//            for (int i = 0; i < Clients.Length; i++)
//            {
//                if(Clients[i].bankCart.PIN==pin&& Clients[i].bankCart.PAN == pan)
//                {
//                    Console.WriteLine($" Cart Balance : {Clients[i].bankCart.Balance_}");
//                    break;
//                }
//            }
//        }
//        public void Show_all()
//        {
//            for (int i = 0; i < Clients.Length; i++)
//            {
//                Clients[i].Show_Client();
//                Console.WriteLine(" - - - - - - - - - - - - - - - - - - - - ");
//            }
//        }

//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            DateTime a=new DateTime(2022,2,2);
//            BankCart bankCart1 = new BankCart("BankCart1","Hatuna Matata","123451","12345671","1231");
//            Client client1 = new Client("Name1","Surname",19,1000,bankCart1);

//            DateTime b=new DateTime(2022,3,3);
//            BankCart bankCart2 = new BankCart("BankCart2","Hatuna Matata","123452","12345672","1232");
//            Client client2 = new Client("Name2","Surname",19,1000,bankCart2);

//            DateTime c=new DateTime(2022,4,4);
//            BankCart bankCart3 = new BankCart("BankCart3","Hatuna Matata","123453","12345673","1233");
//            Client client3 = new Client("Name3","Surname",19,1000,bankCart3);

//            Bank bank=new Bank();
//            bank.AddClients(client1);
//            bank.AddClients(client2);
//            bank.AddClients(client3);
//            bank.Show_all();

//            Console.WriteLine();
//            bank.ShowCartBalance("12345671","123451");
//            bank.ShowCartBalance("12345672","123452");
//            bank.ShowCartBalance("12345673","123453");

//        }

//    }
//}

#endregion

#region Task 2



namespace task2
{
    class Cart
    {
        public string PAN { get; set; }
        public string PIN { get; set; }
        public string CVC { get; set; }
        public string Expire_Date { get; set; }
        public decimal Balance { get; set; }

        Cart()
        {
            PAN = string.Empty;
            PIN = string.Empty;
            CVC = string.Empty;
            Expire_Date = string.Empty;
            Balance = 0;
        }

        public Cart(string pAN, string pIN, string cVC, string expire_Date, decimal balance)
        {
            PAN = pAN;
            PIN = pIN;
            CVC = cVC;
            Expire_Date = expire_Date;
            Balance = balance;
        }

        public void Show_Cart()
        {
            Console.WriteLine($" - - - - - CART Informations - - - - - ");
            Console.WriteLine($" PAN : {PAN} ");
            Console.WriteLine($" PIN : {PIN} ");
            Console.WriteLine($" CVC : {CVC} ");
            Console.WriteLine($" Expire Date : {Expire_Date} ");
            Console.WriteLine($" Balance : {Balance} ");
            Console.WriteLine();
            Console.WriteLine($" + + + + + + + + + + + + + + + + + + + + + ");
        }
    }
    /* 
       2. User adinda bir class yaradirsiniz hansi ki, asagidaki fieldleri var:

    - Name /string
    - Surname /string
    - CreditCard /Card

     */
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Cart CreditCard { get; set; }
        User()
        {
            Name = string.Empty;
            Surname = string.Empty;
            CreditCard = default;
        }

        public User(string name, string surname, Cart creditCard)
        {
            Name = name;
            Surname = surname;
            CreditCard = creditCard;
        }

        public void Show_User()
        {
            Console.WriteLine($" - - - - - User Information - - - - - ");
            Console.WriteLine($" Name : {Name} ");
            Console.WriteLine($" Surname : {Surname} ");
            CreditCard.Show_Cart();
        }
    }

    class Bank
    {
        public User[] Users { get; set; }
        public int UsersCount { get; set; }
        public void Add_user(User newUser)
        {
            var test = new User[++UsersCount];
            if (Users != null)
            {
                Users.CopyTo(test, 0);
            }
            test[UsersCount - 1] = newUser;
            Users = test;
        }
        public void Delete_user_withName(string name)
        {
            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i].Name == name)
                {
                    Users[i] = null;
                    break;
                }
            }
        }
        public void ShowAll_Users()
        {
            for (int i = 0; i < Users.Length; i++)
            {
                Users[i].Show_User();
            }
        }
    }
    class Program
    {

        static void Start(Bank bank)
        {
            int count1 = 0;
            int count3 = 0;
            Console.Clear();
            Console.Write($" Enter PIN : ");
            string InputPIN = Console.ReadLine();
            void Start2()
            {


                for (int i = 0; i < bank.Users.Length; i++)
                {
                    if (bank.Users[i].CreditCard.PIN == InputPIN)
                    {


                        Console.Clear();
                        Console.WriteLine($"  Welcome {bank.Users[i].Name} {bank.Users[i].Surname} ");
                        Console.WriteLine();
                        Console.WriteLine($" Balance [ 1 ] ");
                        Console.WriteLine($" Cash [ 2 ] ");
                        Console.WriteLine($" Moves from card to card [ 3 ] ");
                        Console.WriteLine($" Back [ 4 ] ");

                        Console.WriteLine();
                        Console.Write($" Please Enter : ");
                        string Input_oneORtwo = Console.ReadLine();
                        if (Input_oneORtwo == "1")
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine($" Balance : {bank.Users[i].CreditCard.Balance} ");
                            Console.WriteLine();
                            Console.WriteLine($" Back [ 0 ] ");
                            string Balance_back = Console.ReadLine();
                            if (Balance_back == "0")
                            {
                                count1 = 0;
                                Start2();
                                break;
                            }
                            else
                            {
                                bool a = true;
                                while (a)
                                {

                                    Console.Clear();
                                    Console.WriteLine(" Wrong ");
                                    Console.WriteLine();
                                    Console.WriteLine($" Back [ 0 ] ");
                                    Balance_back = Console.ReadLine();
                                    if (Balance_back == "0")
                                    {
                                        count1 = 0;
                                        a = false;
                                        Start(bank);
                                        break;
                                    }
                                }
                            }

                        }
                        else if (Input_oneORtwo == "2")
                        {
                            Console.Clear();
                            Console.WriteLine($" 10 AZN  [ 1 ] ");
                            Console.WriteLine($" 20 AZN  [ 2 ] ");
                            Console.WriteLine($" 50 AZN  [ 3 ] ");
                            Console.WriteLine($" 100 AZN  [ 4 ] ");
                            Console.WriteLine($" Choose you  [ 5 ] ");
                            Console.WriteLine();
                            Console.Write($" Enter : ");
                            string two_choice = Console.ReadLine();
                            if (two_choice == "1")
                            {
                                if (bank.Users[i].CreditCard.Balance >= 10)
                                {
                                    Console.WriteLine($" Great ");
                                    Thread.Sleep(1500);

                                    bank.Users[i].CreditCard.Balance -= 10;
                                    count1 = 0;
                                }
                                else
                                {
                                    throw new Exception(" Money is less ");
                                }
                                Start(bank);
                                break;
                            }
                            else if (two_choice == "2")
                            {
                                if (bank.Users[i].CreditCard.Balance >= 20)
                                {
                                    Console.WriteLine($" Great ");
                                    Thread.Sleep(1500);

                                    bank.Users[i].CreditCard.Balance -= 20;
                                    count1 = 0;
                                }
                                else
                                {
                                    throw new Exception(" Money is less ");
                                }
                                Start(bank);
                                break;
                            }
                            else if (two_choice == "3")
                            {
                                if (bank.Users[i].CreditCard.Balance >= 50)
                                {
                                    Console.WriteLine($" Great ");
                                    Thread.Sleep(1500);

                                    bank.Users[i].CreditCard.Balance -= 50;
                                    count1 = 0;
                                }
                                else
                                {
                                    throw new Exception(" Money is less ");
                                }
                                Start(bank);
                                break;
                            }
                            else if (two_choice == "4")
                            {
                                if (bank.Users[i].CreditCard.Balance >= 100)
                                {
                                    Console.WriteLine($" Great ");
                                    Thread.Sleep(1500);

                                    bank.Users[i].CreditCard.Balance -= 100;
                                    count1 = 0;
                                }
                                else
                                {
                                    throw new Exception(" Money is less ");
                                }
                                Start(bank);
                                break;
                            }
                            else if (two_choice == "5")
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.Write($" Enter : ");
                                decimal money = Console.Read();
                                if (bank.Users[i].CreditCard.Balance >= money)
                                {
                                    Console.WriteLine($" Great ");
                                    Thread.Sleep(1500);
                                    bank.Users[i].CreditCard.Balance -= money;
                                    count1 = 0;
                                }
                                else
                                {
                                    throw new Exception(" Money is less ");
                                }
                                Start(bank);
                                break;
                            }


                        }
                        else if (Input_oneORtwo == "3")
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.Write($" Enter second PIN : ");
                            string secondPIN = Console.ReadLine();
                            for (int k = 0; k < bank.Users.Length; k++)
                            {
                                if (bank.Users[k].CreditCard.PIN == secondPIN && bank.Users[k].CreditCard.PIN != InputPIN)
                                {
                                    Console.Write($" Enter Amount of Money : ");
                                    decimal Among_money = Console.Read();
                                    if (bank.Users[i].CreditCard.Balance >= Among_money)
                                    {
                                        bank.Users[i].CreditCard.Balance -= Among_money;
                                        bank.Users[k].CreditCard.Balance += Among_money;
                                        Console.Clear();
                                        Console.WriteLine($" Great ");
                                        Thread.Sleep(1500);
                                        count3 = 0;
                                        count1 = 0;
                                        Start(bank);
                                        break;
                                    }
                                }
                                else
                                {
                                    ++count3;
                                }
                            }

                            if (count3 == bank.Users.Length)
                            {

                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine();
                                throw new Exception(" ERROR ");
                            }

                        }
                        else if (Input_oneORtwo == "4")
                        {
                            Start(bank);
                        }

                    }


                    else
                    {

                        ++count1;
                        Start2();
                    }
                }
                if (count1 == bank.Users.Length)
                {
                    Console.Clear();
                    Start(bank);
                }
            }
            Start2();

        }
        static void Main(string[] args)
        {
            Cart cart1 = new Cart("123451", "543211", "1231", " 07/03 ", 2100);
            Cart cart2 = new Cart("123452", "543212", "1232", " 06/12 ", 2200);
            Cart cart3 = new Cart("123453", "543213", "1233", " 05/07 ", 2300);
            Cart cart4 = new Cart("123454", "543214", "1234", " 04/10 ", 2400);
            Cart cart5 = new Cart("123455", "543215", "1235", " 08/11 ", 2500);

            User user1 = new User("T7N", "XXX", cart1);
            User user2 = new User("Elgun", "Mensimov", cart2);
            User user3 = new User("Arif", "Quliyev", cart3);
            User user4 = new User("Akif", "Quliyev", cart4);
            User user5 = new User("Cemil", "Huseynov", cart5);

            Bank bank = new Bank();
            bank.Add_user(user1);
            bank.Add_user(user2);
            bank.Add_user(user3);
            bank.Add_user(user4);
            bank.Add_user(user5);
            Start(bank);

        }
    }


}


#endregion
