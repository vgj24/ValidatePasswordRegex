using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;

namespace RegexAssgn
{
    public class UsingRegistrationFactory
    {
        string message;
        public UsingRegistrationFactory()
        {
                
        }
        public UsingRegistrationFactory(string message)
        {
            this.message = message;
        }
        public  object CreateRegexPassword(string ClassName, String ConstructorName)
        {
            string pattern = @"." + ConstructorName + "$";
            Match result = Regex.Match(ClassName, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type RegexPAssword = assembly.GetType(ClassName);
                    return Activator.CreateInstance(RegexPAssword);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("your input is invalid");
                    throw new RegexCustomException(RegexCustomException.ExceptionType.NO_SUCH_CLASS, "No class Found");
                }
                catch
                {
                    Console.WriteLine("Somethng went wrong");
                }
            }
            else
            {
                throw new RegexCustomException(RegexCustomException.ExceptionType.NO_SUCH_METHOD, "constructor not found");
            }
            return null;
        }
        public object CreateRegexPasswordParameterisedConstructor(string ClassName, string ConstrucorName, string message)
        {
            Type type = typeof(RegexPasswordPgm);
            if (type.Name.Equals(ClassName) || type.FullName.Equals(ClassName))
            {
                if (type.Name.Equals(ConstrucorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new[] { message });
                    return instance;
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.ExceptionType.NO_CONSTRUCTOR_FOUND, "COnstructor Not found");
                }
            }
            else
            {
                throw new RegexCustomException(RegexCustomException.ExceptionType.NO_SUCH_CLASS, "no such class found");
            }
        }
    }
}
