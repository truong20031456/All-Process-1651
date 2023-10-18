using System;
using System.Security.Cryptography;
using System.Security.Principal;

namespace MyApp
{
    public class BankAccount
    {
        public string Name { get; set; }
        public long AccountNumber { get; set; }
        public int Money { get; set; }



        public BankAccount(string name, long accountnumber,int money)
        {
            
            AccountNumber = accountnumber;
            Name = name;
            this.Money = money;
        }
        
        public void Deposit(int Amount)
        {
            this.Money += Amount;
            Console.WriteLine("Deposited " + Amount + " into Account " + AccountNumber + ".New balance: " + Money);
        }
        public void Withdraw(int Amount) 
        { 
            if (this.Money > Amount) 
            { 
            this.Money -= Amount;
                Console.WriteLine("Withdrawn " + Amount + " from account " +AccountNumber + " New balance " + Money);
            }
            
           
                    
            else
            {
                Console.WriteLine("You have run out of money in your account");
            }
        
        }
        public void display() 
        {
            Console.WriteLine($" Account Holder: {Name}" +
                $"\r\nAccount Number: : {AccountNumber}" +
                $"\r\nBalance: {Money}");
        
        }
    






    }



    internal class Program    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("John Doe",123456789,5000);
           

            Console.WriteLine("===== Bank Account Management =====\n");
            account1.Deposit(1000);
            account1.Withdraw(50000);
            account1.display();
           




        }
    }
}