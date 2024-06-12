using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

            if (name == "")
            {
                err.Add("Name cannot be blank!"); 
            }
            try
            {
                if (splitName[0] + splitName[1] == splitName[0])
                {
                    err.Add("More than one name must be added!");
                }
            }catch (Exception ex)
            {
                err.Add("More than one name must be added!");
            }
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

            string[] addressPieces = address.Split(',');

            if (address == "")
            {
                err.Add("Address should not be empty!"); 
            }

            if (addressPieces.Length != 3)
            {
                err.Add("Invalid Address Format \nCorrect Format: [Street Address], [Parish], [Country] \n- No commas except to seperate these parts");
            }

            return err;
        }

        public List<string> CheckAddVehicle(string vehicle)
        {
            List<string> err = new List<string>();

             

            return err;
        }

        public List<string> CheckEngineNum(string engineNum)
        {
            List<string> err = new List<string>();

            string[] splitEngineNum = engineNum.Split(' ');

            if (engineNum.Length == 0)
            {
                err.Add("Engine Number cannot be blank!");
            }

            //Too many words
            if (splitEngineNum.Length > 1)
            {
                err.Add("Invalid engine number format!");
            }
            return err;
        }

        public List<string> CheckChassisNum(string chassisNum)
        {
            List<string> err = new List<string>();

            string[] splitChassisNum = chassisNum.Split(' '); 

            if (chassisNum.Length == 0)
            {
                err.Add("Chassis Number cannot be blank!");
            }

            //Too many words
            if (splitChassisNum.Length > 1)
            {
                err.Add("Invalid chassis number format!");
            }

            return err;
        }
        
        public List<string> CheckColour(string colour)
        {
            List<string> err = new List<string>();

            if (colour.Length == 0)
            {
                err.Add("Colour cannot be blank!");
            }

            return err;
        }

        public List<string> CheckPrices(string price)
        {
            List<string> err = new List<string>();
             
            if (price.Length == 0)
            {
                err.Add("Vehicles should have both an asking price and valuation price!");
            }
            else
            {
                string[] checkForExtraDots = price.Split('.');

                if (checkForExtraDots.Length > 2)
                {
                    err.Add("Price contains too many periods.\nFormat is [10000.00]");
                }
            }

            return err;
        }

        public List<string> CheckMake(string make)
        {
            List<string> err = new List<string>();

            if (make.Length == 0)
            {
                err.Add("Vehicles should have a make!");
            } 

            return err;
        }

        public List<string> CheckModel(string model)
        {
            List<string> err = new List<string>();

            if (model.Length == 0)
            {
                err.Add("Vehicles should have a model!");
            }

            return err;
        }
    }
}
