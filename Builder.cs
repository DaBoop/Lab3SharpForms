using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2SharpForms
{
    public interface IAccountBuilder
    {
        Account Obj { get; set; }

        Account BuildOwner(string FullName, DateTime BirthDate, string PassportID);
        Account BuildMain(int ID, int Balance, DateTime StartDate);
        Account BuildType();

        

    }
    public class PremiumBuilder : IAccountBuilder
    {
        public Account Obj { get; set; }

        public PremiumBuilder(Account Obj)
        {
            this.Obj = Obj;
        }

        public PremiumBuilder()
        {
            this.Obj = new Account();
        }

        public Account BuildOwner(string FullName, DateTime BirthDate, string PassportID)
        {
            Obj.AccountOwner = new Owner(FullName, BirthDate, PassportID);
            return Obj;
        }

        public Account BuildMain(int ID, int Balance, DateTime StartDate)
        {
            Obj.ID = ID;
            Obj.Balance = Balance;
            Obj.StartDate = StartDate;
            return Obj;

        }
        public Account BuildType()
        {
            Obj.OnlineBanking = true;
            Obj.SMSNotification = true;
            return Obj;
        }
    }
    public class BasicBuilder : IAccountBuilder
    {
        public Account Obj { get; set; }

        public BasicBuilder(Account Obj)
        {
            this.Obj = Obj;
        }

        public BasicBuilder()
        {
            this.Obj = new Account();
        }

        public Account BuildOwner(string FullName, DateTime BirthDate, string PassportID)
        {
            Obj.AccountOwner = new Owner(FullName, BirthDate, PassportID);
            return Obj;
        }

        public Account BuildMain(int ID, int Balance, DateTime StartDate)
        {
            Obj.ID = ID;
            Obj.Balance = Balance;
            Obj.StartDate = StartDate;
            return Obj;

        }
        public Account BuildType()
        {
            Obj.OnlineBanking = true;
            Obj.SMSNotification = false;
            return Obj;
        }
    }
    public class ReducedBuilder : IAccountBuilder
    {
        public Account Obj { get; set; }

        public ReducedBuilder(Account Obj)
        {
            this.Obj = Obj;
        }

        public ReducedBuilder()
        {
            this.Obj = new Account();
        }

        public Account BuildOwner(string FullName, DateTime BirthDate, string PassportID)
        {
            Obj.AccountOwner = new Owner(FullName, BirthDate, PassportID);
            return Obj;
        }

        public Account BuildMain(int ID, int Balance, DateTime StartDate)
        {
            Obj.ID = ID;
            Obj.Balance = Balance;
            Obj.StartDate = StartDate;
            return Obj;

        }
        public Account BuildType()
        {
            Obj.OnlineBanking = false;
            Obj.SMSNotification = false;
            return Obj;
        }
    }

    public class AccountBuildDirector
    { 
        public Account Obj { get; set; }
        public AccountBuildDirector() 
        {
            
        }

        public Account BuildObject(IAccountBuilder builder, string fullName, DateTime birthDate, string passportID, int ID, int balance, DateTime registrationDate)
        {
            builder.BuildOwner(fullName, birthDate, passportID);
            builder.BuildMain(ID, balance, registrationDate);
            builder.BuildType();
            Obj = builder.Obj;
            return Obj;
        }
    }

    
}


