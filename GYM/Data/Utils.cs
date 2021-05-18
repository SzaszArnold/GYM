using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GYM.Data
{
    public class Utils
    {
        public static bool isValidEmail(string email)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(email))
                isValid = false;
            else
            {
                try
                {
                    MailAddress m = new MailAddress(email);
                    isValid = true;
                }
                catch (FormatException fx)
                {
                    isValid = false;
                }
            }
            return isValid;
        }
        public static bool IsValidName(string nameInput)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(nameInput))
                isValid = false;
            else
            {
                isValid = Regex.IsMatch(nameInput, @"^[a-zA-Z]+$");
            }
            return isValid;
        }
        public static bool IsOnlyDigits(string inputString)
        {
            bool isValid = true;

            foreach (char c in inputString)
            {
                if (!Char.IsDigit(c))
                    isValid = false;
            }
            return isValid;
        }
    }

}
