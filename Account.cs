using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2SharpForms
{
    [Serializable]
    public class Owner
    {
        public Owner() { }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Недопустимая длина имени")]
        public string FullName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        //[Required]
        [PassportIDValidate("Неправильный номер паспорта")]
        public string PassportID { get; set; }

        public Owner(string _FullName, DateTime _BirthDate, string _PassportID) => (FullName, BirthDate, PassportID) = (_FullName, _BirthDate, _PassportID);
    }
    [Serializable]
    public class OperationData
    {

        public Operation OperationType { get; set; }
        public DateTime OperationDate { get; set; }
        public int Sum { get; set; }

        public OperationData(Operation operationType, DateTime operationDate, int sum)
        {
            OperationType = operationType;
            OperationDate = operationDate;
            Sum = sum;
        }

        public OperationData(string operationType, DateTime operationDate, int sum)
        {
            try
            {
                OperationType = (Operation)Enum.Parse(typeof(Operation), operationType);
                OperationDate = operationDate;
                Sum = sum;
            }
            catch (Exception e) { }
        }
        public OperationData() { }
    }

    [Serializable]
    public class History
    {
        public List<OperationData> list = new List<OperationData>();
        public OperationData this[int i]
        {
            get => list[i];
            set => list[i] = value;
        }
       

        public History()
        {
        }
    }
    [Serializable]
    public class Account
    {
        public History AccountHistory;
        public Account() { }
        [Required]
        //[StringLength(50, MinimumLength = 3, ErrorMessage = "Недопустимая длина имени")]
        public Owner AccountOwner { get; set; }

        [Required]
        [RegularExpression(@"^[1-9]{5}$", ErrorMessage = "Номёр счёта должен содержать 5 цифр")]
        private int id;
        public int ID {
            get => id;
            set
            {
                if (value < 0)
                    throw new ArgumentNullException("ID can't be negative");
                else id = value;

            }
        }
        [Required]
        [Range(-999999, 999999, ErrorMessage = "Недопустимый возраст")]
        private int balance;

        public int Balance
        {
            get => balance;
            set
            {
                // if (value < 0)
                //     throw new ArgumentNullException("Balance can't be negative");
                // else balance = value;
                balance = value;

            }
        }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public bool OnlineBanking { get; set; }
        [Required]
        public bool SMSNotification { get; set; }

        public Account(int _ID, int _Balance, DateTime _StartDate, bool _OnlineBanking = false, bool _SMSNotification = false, Owner _AccountOwner = null, History _accountHistory = null)
        {

          

            (ID, Balance, StartDate, OnlineBanking, SMSNotification, AccountOwner, AccountHistory) = (_ID, _Balance, _StartDate, _OnlineBanking, _SMSNotification, _AccountOwner, _accountHistory);
        }
    }

    public enum Operation
    {
        Deposit,
        Withdraw
        
    }
}
