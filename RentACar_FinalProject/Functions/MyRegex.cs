﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RentACar_FinalProject.Functions
{
    public static class MyRegex
    {
        #region Patterns

        private const string _PatternOfLettersStartWithUppercase = @"^[A-Z]+[a-zA-Z]*$";
        private const string _PatternOfLetters = @"^[a-zA-Z ]+[a-zA-Z]$";
        private const string _PatternOfNumber = @"^[0-9]+$";
        private const string _PatternOfLettersAndNumber = @"^[a-zA-Z0-9]+$";
        private const string _PatternOfPhone = @"^(050|055|051|077|070|010|099)-\d{3}-\d{2}-\d{2}$";
        private const string _PatternOfEmail = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

        #endregion

        #region Methods for check

        public static bool CheckLettersStartWithUppercase(string str)
        {
            if (Regex.IsMatch(str, _PatternOfLettersStartWithUppercase)) return true;
            else return false;
        }

        public static bool CheckLetters(string name)
        {
            if (Regex.IsMatch(name, _PatternOfLetters)) return true;
            else return false;
        }

        public static bool CheckNumber(string numbers)
        {
            if (Regex.IsMatch(numbers, _PatternOfNumber)) return true;
            else return false;
        }

        public static bool CheckLettersAndNumber(string str)
        {
            if (Regex.IsMatch(str, _PatternOfLettersAndNumber)) return true;
            else return false;
        }

        public static bool CheckPhone(string phone)
        {
            if (Regex.IsMatch(phone, _PatternOfPhone)) return true;
            else return false;
        }

        public static bool CheckEmail(string email)
        {
            if (Regex.IsMatch(email, _PatternOfEmail)) return true;
            else return false;
        }
        #endregion
    }
}
