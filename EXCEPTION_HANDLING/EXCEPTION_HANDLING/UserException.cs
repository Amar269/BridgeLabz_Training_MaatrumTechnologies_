using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCEPTION_HANDLING
{
    internal class UserException : Exception
    {
        public UserException() { }
        public UserException(string message) : base(message) { }
    }
}
