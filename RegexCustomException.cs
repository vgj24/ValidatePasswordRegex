using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexAssgn
{
    internal class RegexCustomException : Exception
    {
        public enum ExceptionType
        {
            NULLVALUE_EXCEPTION,
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_MOBILENUMBER,
            INVALID_EMAIL,
            INVALID_PASSWORD
        }
        private readonly ExceptionType type;
        public RegexCustomException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
