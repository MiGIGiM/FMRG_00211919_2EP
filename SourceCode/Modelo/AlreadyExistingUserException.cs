using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.Modelo
{
    class AlreadyExistingUserException : Exception
    {
        public AlreadyExistingUserException()
        {

        }

        public AlreadyExistingUserException(string message) : base()
        {

        }
    }
}
