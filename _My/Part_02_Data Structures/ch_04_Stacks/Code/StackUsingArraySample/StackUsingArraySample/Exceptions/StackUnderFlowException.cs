using System;
using System.Collections.Generic;
using System.Text;

namespace StackUsingArraySample.Exceptions
{
    public class StackUnderFlowException : Exception
    {
        public StackUnderFlowException(string message = "") : base(message)
        {

        }
    }
}
