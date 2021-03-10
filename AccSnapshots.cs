using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2SharpForms
{
    public partial class Account
    {
        CareTaker history = new CareTaker();

        void onBalanceChanged(Object sender, EventArgs args)
        {
            SaveState();
        }


        public void SaveState()
        {

            history.PushSnapshot(this);
        }

        public void RestoreState()
        {
            
            var account = history.GetLastSnapshot();

            this.AccountOwner = account.AccountOwner;
            this.ID = account.ID;
            this.Balance = account.Balance;
            this.SMSNotification = account.SMSNotification;
            this.OnlineBanking = account.OnlineBanking;
            this.StartDate = account.StartDate;

            account.history.GetLastSnapshot();
            
        }
    }
    public class CareTaker
    {
        Stack<Account> history = new Stack<Account>();

        public CareTaker()
        {
            
        }

        public CareTaker(Account memento)
        {
            this.history.Push(memento.Clone());
        }

        public void PushSnapshot(Account memento)
        {
            this.history.Push(memento.Clone());
        }

        public Account GetLastSnapshot()
        {
            history.Pop();
            return history.Peek();
        }
    }
    /*
    public class Memento
    {
        public Account State { get; set; }
        //public Account this[int i]
        //{
        //    get { return snapshotList[i]; }
        //    private set { snapshotList[i] = value;  }
        //}
        public Memento(Account state)
        {
            this.State = state;
        }

        public Memento()
        {

        }

    }*/
}
