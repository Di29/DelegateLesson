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

            //account.ActionEvent += new Messenger().SendMessenger;
            account.ActionEvent += delegate (string message)
            {
                Console.WriteLine(message);
            };

            account.ActionEvent += (message) => Console.WriteLine(message);
            //тоже самое

            account.Add(1000);
            account.Withdraw(500);

            List<Account> accounts = new List<Account>
            {
                new Account(),
                new Account(),
                new Account(),
                new Account(),
                new Account(),
            };

            List<Account> resultAccount = new List<Account>();
            foreach(var acc in accounts)
            {
                if(acc.Sum >= 500)
                {
                    resultAccount.Add(acc);
                }
            }

            var result = accounts.Where(acc => acc.Sum >= 500);
            var result2 = from acc
                          in accounts
                          where acc.Sum >= 500
                          select acc;

            Console.ReadLine();
        }

        
    }
}
