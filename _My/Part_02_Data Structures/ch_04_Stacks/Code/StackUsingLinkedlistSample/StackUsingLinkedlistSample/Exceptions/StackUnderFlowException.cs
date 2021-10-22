using System;
using System.Collections.Generic;
using System.Text;

namespace StackUsingLinkedlistSample.Exceptions
{
    public class StackUnderFlowException : Exception
    {
        public StackUnderFlowException(string message = "") : base(message)
        {

        }
    }
}
