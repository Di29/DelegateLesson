using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem__DelegateLesson_
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.ActionEvent += new Messenger().SendMessenger;

            account.Add(1000);
            account.Withdraw(500);
            Console.ReadLine();
        }

        //static void SendMessage(string message)
        //{
        //    Console.WriteLine(message);
        //}
    }
}
