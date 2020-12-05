using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignmentPart2
{
    public class NegativeZerosException: Exception
    {
        public NegativeZerosException()
            : base() { }
        public NegativeZerosException(string message)
            : base(message) { }
    }
}
