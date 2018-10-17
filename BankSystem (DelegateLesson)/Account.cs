using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem__DelegateLesson_
{
    public delegate void MessegeHandler(string messege);
    public class Account
    {
        public event MessegeHandler ActionEvent;

        public int Sum { get; private set; }
       
        

        public void Add (int sum)
        {
            Sum += sum;
            ActionEvent?.Invoke("Вы добавили на свой счет " + sum);
        }

        public void Withdraw(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                ActionEvent?.Invoke("Вы сняли на своего счета " + sum + ". Остаток " + Sum);
            }
            else
                ActionEvent?.Invoke("Недостаточно средтсв");
        }

        

    }
}
