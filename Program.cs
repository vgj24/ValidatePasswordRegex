// See https://aka.ms/new-console-template for more information
using RegexAssgn;
Console.WriteLine("Regex Password assignment");

RegexPasswordPgm rg =new RegexPasswordPgm();
rg.Validating();
//RegexUsingException ex=new RegexUsingException();
//Console.WriteLine("enter option:");
//Console.WriteLine("1: enter first name");
//Console.WriteLine("2 : enter last name");
//Console.WriteLine("3 : enter emailid");
//Console.WriteLine("4 : enter mobile number");
//Console.WriteLine("5 : enter password");
//Console.WriteLine("\n\n");
//int input=Convert.ToInt32(Console.ReadLine());
////switch (input)
//{
//    case 1:
//        try
//        {
//            Console.WriteLine(result);
           
//        break;
//    case 2:
//        try
//        {
//            Console.WriteLine("Enter Last NAme");
//            string Lname = Console.ReadLine();
//            bool result = rg.ValidateLastname(Lname);
//            Console.WriteLine(result);
//            if (result == false)
//            {
//                throw new RegexCustomException(RegexCustomException.ExceptionType.INVALID_LASTNAME, "YOU HAVE ENTERED INVALID LAST NAME");

//            }
//        }
//        catch
//        {
//            throw new RegexCustomException(RegexCustomException.ExceptionType.INVALID_LASTNAME, "YOU HAVE ENTERED INVALID LAST NAME");

//        }
//        break;

//    case 3:
//        try
//        {
//            Console.WriteLine("Enter Email");
//            string emailid = Console.ReadLine();
//            bool result = rg.ValidateEmail(emailid);
//            Console.WriteLine(result);
//            if (result == false)
//            {
//                throw new RegexCustomException(RegexCustomException.ExceptionType.INVALID_EMAIL, "YOU HAVE ENTERED INVALID EMAILID");
//            }
//        }
//        catch
//        {
//            throw new RegexCustomException(RegexCustomException.ExceptionType.INVALID_EMAIL, "YOU HAVE ENTERED INVALID EMAILID");
//        }
//        break;
//    case 4:
//        try
//        {
//            Console.WriteLine("emter mobile number");
//            string MobNum = Console.ReadLine();
//            bool result = rg.ValidateMobileNumber(MobNum);
//            Console.WriteLine(result);
//            if (result == false)
//            {
//                throw new RegexCustomException(RegexCustomException.ExceptionType.INVALID_MOBILENUMBER, "YOU HAVE ENTERED INVALID MOBILENUMBER");
//            }
//        }
//        catch
//        {
//            throw new RegexCustomException(RegexCustomException.ExceptionType.INVALID_MOBILENUMBER, "YOU HAVE ENTERED INVALID MOBILENUMBER");
//        }
//        break;
//    case 5:
//        try
//        {
//            Console.WriteLine("enter password");
//            string pwd = Console.ReadLine();
//            bool result = rg.ValidatePassword(pwd);
//            Console.WriteLine(result);
//            if (result == false)
//            {
//                throw new RegexCustomException(RegexCustomException.ExceptionType.INVALID_PASSWORD, "YOU HAVE ENTERED INVALID PASSWORD");
//            }
//        }
//        catch
//        {
//            throw new RegexCustomException(RegexCustomException.ExceptionType.INVALID_PASSWORD, "YOU HAVE ENTERED INVALID PASSWORD");

//        }
//        break;
//}
//        Console.ReadKey();