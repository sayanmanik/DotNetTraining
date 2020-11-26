using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditLimitValidationException
{
    class InvalidCreditLimitException : ApplicationException
    {
        public InvalidCreditLimitException() : base()
        {

        }

        public InvalidCreditLimitException(string msg) : base(msg)
        {

        }
    }
}
