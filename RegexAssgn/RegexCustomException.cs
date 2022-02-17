using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexAssgn
{
    public class RegexCustomException : Exception
    {
        public string message;
        public enum ExceptionType
        {
            NULLVALUE_EXCEPTION,
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_MOBILENUMBER,
            INVALID_EMAIL,
            INVALID_PASSWORD,
            NO_SUCH_CLASS,
            NO_CONSTRUCTOR_FOUND,
            NO_SUCH_METHOD,
        }
        private readonly ExceptionType type;
        public RegexCustomException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
