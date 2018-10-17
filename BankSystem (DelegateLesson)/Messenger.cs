using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem__DelegateLesson_
{
    public class Messenger : IMessenger
    {
        public void SendMessenger(string messege)
        {
            Console.WriteLine(messege);
        }
    }
}
