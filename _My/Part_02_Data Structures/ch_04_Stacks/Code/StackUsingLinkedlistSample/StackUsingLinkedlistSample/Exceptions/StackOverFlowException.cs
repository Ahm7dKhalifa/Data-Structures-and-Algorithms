using System;
using System.Collections.Generic;
using System.Text;

namespace StackUsingLinkedlistSample.Exceptions
{
    public class StackOverFlowException : Exception
    {
        public StackOverFlowException(string message = "") : base(message)
        {

        }
    }
}
