using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegexAssgn
{
    public class RegexPasswordPgm
    {
        public string message;
        public static string FirstNamePattern = "^[A-Z][a-z]{2,}$";//UC1:first gec 
        public static string LastNamePattern = "^[A-Z][a-z]{2,}$";//UC2: last name
        public static string EmailPattern = "^[A-Za-z0-9]+([.#_+-][A-Za-z0-9]+)*[@][A-Za-z0-9]+[.][a-z]{2,3}([.][a-z]{2,3})?$"; //UC3:email ,uc9: valide all email samples
        public static string MobileNumberPattern = @"^[0-9]+[\s]+[0-9]{10}$"; //UC4: mobile number
        public static string PASSWORDPattren = "^(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%&_-])(?=.*[A-Z])[a-zA-Z0-9!@#$%&_-]{8,}$";

        public RegexPasswordPgm()
        {

        }
        public RegexPasswordPgm(string message)
        {
            this.message = message;
        }
        public void Validating()
        {
            Console.WriteLine("**************************");

            Console.WriteLine("Validating First name");
            Console.WriteLine("Enter First Name");
            string FirstName = Console.ReadLine();
            ValidateFirstname(FirstName);
            Console.WriteLine("**************************");
            Console.WriteLine("Validating Lastt Name");
            Console.WriteLine("Enter Last NAme");
            string LastName = Console.ReadLine();
            ValidateLastname(LastName);
            Console.WriteLine("**************************");

            Console.WriteLine("Validating Email Id");
            Console.WriteLine("Enter Email Id");
            string Emailid = Console.ReadLine();
            ValidateEmail(Emailid);
            Console.WriteLine("**************************");

            Console.WriteLine("Validating Mobile Number");
            Console.WriteLine("Enter MObileNumber");
            string MobileNumber = Console.ReadLine();
            ValidateMobileNumber(MobileNumber);

            Console.WriteLine("**************************");

            Console.WriteLine("Validating Password");
            Console.WriteLine("Enter Password");
            string Password = Console.ReadLine();
            ValidatePassword(Password);
            Console.WriteLine("**************************");
        }
        #region Validate First Name
        public static Func<string, string> ValidateFirstname = (FirstName) => //uc 13 using lambda expression 
           {
            //Regex FirstName = new Regex(FirstNamePattern);
            Console.Write(" " + FirstName);
               bool regex = Regex.IsMatch(FirstName, FirstNamePattern);
               try
               {
                   if (FirstName.Equals(String.Empty))
                   {
                       throw new RegexCustomException(RegexCustomException.ExceptionType.NULLVALUE_EXCEPTION, "Name can not be empty");
                   }
                   if (FirstName.Equals(null))
                   {
                       throw new RegexCustomException(RegexCustomException.ExceptionType.NULLVALUE_EXCEPTION, "Name can not be null");
                   }
                   if (regex)
                   {
                       Console.WriteLine("Valid");
                       return FirstName;
                   }
                   else
                   {
                       throw new RegexCustomException(RegexCustomException.ExceptionType.INVALID_FIRSTNAME, "YOU HAVE ENTERED INVALID FIRST NAME");

                   }
               }
               catch (NullReferenceException ex)
               {
                  return ex.Message;
               }
           };

        #endregion
        #region ValidateLastname
        public static Func<string, string> ValidateLastname = (LastName) =>
          {
              Console.Write(" " + LastName);
              bool result = Regex.IsMatch(LastName, LastName);
              try
              {
                  if (LastName.Equals(String.Empty))
                  {
                      throw new RegexCustomException(RegexCustomException.ExceptionType.NULLVALUE_EXCEPTION, "Name can not be empty");
                  }
                  if (LastName.Equals(null))
                  {
                      throw new RegexCustomException(RegexCustomException.ExceptionType.NULLVALUE_EXCEPTION, "Name can not be null");
                  }
                  if (result)
                  {
                      Console.WriteLine("Valid");
                      return LastName;
                  }
                  else
                  {
                      throw new RegexCustomException(RegexCustomException.ExceptionType.INVALID_LASTNAME, "YOU HAVE ENTERED INVALID LAST NAME");

                  }
              }
              catch (NullReferenceException ex)
              {
                  return ex.Message;
              }

          };
        #endregion

        #region ValidateEmail
        public static Func<string, string> ValidateEmail = (Emailid) =>
          {
              Console.Write(" " + Emailid);
              bool result = Regex.IsMatch(Emailid, EmailPattern);
              try
              {
                  if (Emailid.Equals(String.Empty))
                  {
                      throw new RegexCustomException(RegexCustomException.ExceptionType.NULLVALUE_EXCEPTION, "EmailId can not be empty");
                  }
                  if (Emailid.Equals(null))
                  {
                      throw new RegexCustomException(RegexCustomException.ExceptionType.NULLVALUE_EXCEPTION, "EmailId can not be null");
                  }
                  if (result)
                  {
                      Console.WriteLine("Valid");
                      return Emailid;
                  }
                  else
                  {
                      throw new RegexCustomException(RegexCustomException.ExceptionType.INVALID_EMAIL, "YOU HAVE ENTERED INVALID Emaid");

                  }
              }
              catch (NullReferenceException ex)
              {
                  return ex.Message;
              }
          };

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
        public static Func<string, string> ValidateMobileNumber = (MobileNumber) =>
           {
               bool result = Regex.IsMatch(MobileNumber, MobileNumberPattern);

               Console.Write(" " + MobileNumber);
               try
               {
                   if (MobileNumber.Equals(String.Empty))
                   {
                       throw new RegexCustomException(RegexCustomException.ExceptionType.NULLVALUE_EXCEPTION, "Mobile Number can not be empty");
                   }
                   if (MobileNumber.Equals(null))
                   {
                       throw new RegexCustomException(RegexCustomException.ExceptionType.NULLVALUE_EXCEPTION, "Mobile Number can not be null");
                   }
                   if (result)
                   {
                       Console.WriteLine("Valid");
                       return MobileNumber;
                   }
                   else
                   {
                       throw new RegexCustomException(RegexCustomException.ExceptionType.INVALID_MOBILENUMBER, "YOU HAVE ENTERED INVALID MobileNumber");

                   }
               }
               catch (NullReferenceException ex)
               {
                   return ex.Message;
               }

           };
        #endregion
        #region ValidatePassword
        public static Func<string, string> ValidatePassword = (Password) =>
          {
              Console.Write("password :" + Password);
              bool result = Regex.IsMatch(Password, PASSWORDPattren);
              try
              {
                  if (Password.Equals(String.Empty))
                  {
                      throw new RegexCustomException(RegexCustomException.ExceptionType.NULLVALUE_EXCEPTION, "Password can not be empty");
                  }
                  if (Password.Equals(null))
                  {
                      throw new RegexCustomException(RegexCustomException.ExceptionType.NULLVALUE_EXCEPTION, "Password can not be null");
                  }
                  if (result)
                  {
                      Console.WriteLine("Valid");
                      return Password;
                  }
                  else
                  {
                      throw new RegexCustomException(RegexCustomException.ExceptionType.INVALID_PASSWORD, "YOU HAVE ENTERED INVALID Password");

                  }
              }
              catch (NullReferenceException ex)
              {
                  return ex.Message;
              }
          };
        #endregion

    }
}
