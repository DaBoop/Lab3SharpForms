using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2SharpForms
{
    abstract class AccountDecorator : Account
    {
        //Account account;
        
        public void SetDecorator(Account account)
        {
            //this.account = account;

            this.AccountOwner = account.AccountOwner;
            this.ID = account.ID;
            this.Balance = account.Balance;
            this.SMSNotification = account.SMSNotification;
            this.OnlineBanking = account.OnlineBanking;
            this.StartDate = account.StartDate;
        }

        public AccountDecorator()
        {

        }

    }

    class BusinessAccount : AccountDecorator
    {
        bool businessDicount = true;
        public bool HasBusinessDiscount { get => businessDicount; }
        public BusinessAccount()
        {
        }

        new public void SetDecorator(Account account)
        {
            base.SetDecorator(account);
        }



    }

    class PremiumAccount : AccountDecorator
    {
        bool premiumFeatures = true;

        public bool HasPremiumFeatures { get => premiumFeatures; }
        new public void SetDecorator(Account account)
        {
            base.SetDecorator(account);
        }

        public PremiumAccount()
        {

        }

    }
}

