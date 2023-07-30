using RentACar_FinalProject.Functions;
using RentACar_FinalProject.Models.Classes.UserClasses;
using RentACar_FinalProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_FinalProject.Models.Classes.AbstractClasses
{
    public abstract class User : IiD
    {

        #region Fields

        //  ID
        public Guid ID { get; init; }

        //  Username
        private string _username;
        public string Username
        {
            get { return _username; }
            set 
            {
                if (MyRegex.CheckLetters(value))
                {
                    _username= value;
                }
                else
                {
                    throw new Exception("Username exist can onlu letters!");
                }
            }
        }

        //  Password
        private string _password;
        public string Password
        {
            get { return _password; }
            set 
            {
                if (MyRegex.CheckLetters(value))
                {
                    _password = value;
                }
                else
                {
                    throw new Exception("Username exist can onlu letters!");
                }
            }
        }

        // BankCard of user
        public BankCard Card { get; set; }

        #endregion

        #region Operations
        protected User(string username, string password, BankCard card)
        {
            ID = Guid.NewGuid();
            Username = username;
            Password = password;
            Card = card;
        }

        #endregion


    }
}
