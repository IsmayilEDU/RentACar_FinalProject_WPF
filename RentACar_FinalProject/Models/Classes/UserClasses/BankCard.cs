﻿using RentACar_FinalProject.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_FinalProject.Models.Classes.UserClasses
{
    public class BankCard
    {

        #region Fields

        //  Name of bank
        private string _BankName;
        public string BankName
        {
            get { return _BankName; }
            init 
            {
                if (MyRegex.CheckLettersStartWithUppercase(value))
                {
                    _BankName = value;
                }
                else
                {
                    throw new Exception("Name of bank shoul be start with uppercase!");
                }
            }
        }

        //  Numbers of card
        private string _CardNumber;
        public string CardNumber
        {
            get { return _CardNumber; }
            init 
            {
                if ((value.Length == 16) && (MyRegex.CheckNumber(value)))
                {
                    _CardNumber = value;
                }
                else
                {
                    throw new Exception("Numbers of card should be only exist numbers!");
                }
            }
        }

        //  ExpirationDate of card
        private DateTime _ExpirationDate;
        public DateTime ExpirationDate
        {
            get { return _ExpirationDate; }
            init
            {
                if (value > DateTime.Now)
                {
                    _ExpirationDate = value;
                }
                else
                {
                    throw new Exception("Expiration date should be more than this time!");
                }
            }
        }

        private string _CVC;


        public string CVC
        {
            get { return _CVC; }
            init
            {
                if ((value.Length == 3) && (MyRegex.CheckNumber(value)))
                {
                    _CVC = value;
                }
                else
                {
                    throw new Exception("Numbers of card should be only exist numbers!");
                }
            }
        }

        private double _balance;

        public double Balance
        {
            get { return _balance; }
            set
            {
                if (value > 0)
                {
                    _balance = value;
                }
                else
                {
                    throw new Exception("Balance should be only positive number!");
                }
            }
        }


        #endregion

        #region Operations

        public BankCard(string bankName, string cardNumber, DateTime expirationDate, string cVC, double balance)
        {
            BankName = bankName;
            CardNumber = cardNumber;
            ExpirationDate = expirationDate;
            CVC = cVC;
            Balance = balance;
        }

        #endregion
    }
}
