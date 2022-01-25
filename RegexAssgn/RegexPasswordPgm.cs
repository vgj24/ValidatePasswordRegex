using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegexAssgn
{
    internal class RegexPasswordPgm
    {
        public static string FirstName = "^[A-Z][a-z]{2,}$";//UC1:first name
        public static string LastName = "^[A-Z][a-z]{2,}$";//UC2: last name
        public static string Email = "^[A-Za-z0-9]+([.#_+-][A-Za-z0-9]+)*[@][A-Za-z0-9]+[.][a-z]{2,3}([.][a-z]{2,3})?$"; //UC3:email ,uc9: valide all email samples
        public static string MobileNumber = "^[0-9]{2}[ ][7,8,9][0-9]{9}$"; //UC4: mobile number
        public static string PASSWORD = "^(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%&_])(?=.*[A-Z])[a-zA-Z0-9!@#$%&_]{8,}$";

#region Validate First Name
public bool ValidateFirstname(string Fname)
        {
            Console.Write(" "+Fname);
            return Regex.IsMatch(Fname, FirstName);
        }
        #endregion
        #region ValidateLastname
        public bool ValidateLastname(string Lname)
        {
            Console.Write(" "+Lname);
            return Regex.IsMatch(Lname, LastName);
        }
        #endregion

        #region ValidateEmail
        public bool ValidateEmail(string sampleemail)
        {
            Console.Write(" "+sampleemail);
            return Regex.IsMatch(sampleemail,Email);
        }

        #endregion
        #region to pass all givenmails
        /*to validdate all emailid
         * abc@yahoo.com
         * abc-100@yahoo.com
         * abc.100@yahoo.com
         * abc11@yahoo.com
         * abc_100@abc.net
         * abc.100@abc.com.au
         * abc@1.com
         * abc@gmail.com.com
         * abc+100@gmail.com
        */
        #endregion

        #region validateMobile number
        public bool ValidateMobileNumber(string mobnum)
        {
            Console.Write(" "
                +mobnum);
            return Regex.IsMatch(mobnum, MobileNumber);
        }
        #endregion
        #region ValidatePassword
        public bool ValidatePassword(string pwd)
        {
            Console.Write("password :"+pwd);
            return Regex.IsMatch(pwd, PASSWORD);
        }
        #endregion

    }
}
