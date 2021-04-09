﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Database_Application_Chris
{
    class validation
    {
        public List<string> CheckName(string name)
        {
            List<string> err = new List<string>();

            string[] splitName = name.Split(' ');
            bool tooManySpaces = false;

            if (splitName.Length > 2)
            {
                int countNames = 0;

                foreach (var r in splitName)
                {
                    if (r.Equals(""))
                    {
                        if (!tooManySpaces)
                        {
                            err.Add("Too many spaces between names");
                            tooManySpaces = true;
                        }
                    } else
                    {
                        countNames++;
                    }
                }
                if (countNames > 2)
                {
                    err.Add("Please only enter two names");
                }

            }
            else // Once theres adequate spaces between names - Check for letter formatting
            {
                foreach (var piece in splitName)
                {
                    bool IsAlphabet = Regex.IsMatch(piece, @"^[a-zA-Z]+$");

                    if (IsAlphabet) //
                    {
                        string upperCaseCheck = piece.ToString();

                        if (!char.IsUpper(upperCaseCheck[0]))
                        {
                            err.Add("Please capitalize the first letter of each name");
                        }
                    }
                    if (!IsAlphabet) // Not all letters in name
                    {
                        err.Add("Please only use letters");
                    }
                }
            }
            return err;
        }

        public List<string> CheckEmail(string email)
        {
            List<string> err = new List<string>();

            try
            {
                string[] TestEmail = email.Split(' ');

                if (TestEmail.Length > 1)
                {
                    throw new ArgumentException("Invalid Email"); //Throw exception as email is invalid 
                }

                // Else check formatting of email
                var addr = new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                err.Add("Invalid email format");
            }

            return err;
        }

        public List<string> CheckNum(string number)
        {
            List<string> err = new List<string>();

            string extractedNum = "";

            for (int i = 0; i < number.Length; i++)
            {
                if (Char.IsDigit(number[i]))
                {
                    extractedNum += number[i];
                }
            } 
            if ((extractedNum.Length != 7) && (extractedNum.Length != 10)  && (extractedNum.Length != 11))
            {
                err.Add("Number format invalid");
            } 

            return err;
        }

        public List<string> CheckAddress(string address)
        {
            List<string> err = new List<string>();


            return err;
        }

        public List<string> CheckAddVehicle(string vehicle)
        {
            List<string> err = new List<string>();

             

            return err;
        }



    }
}
