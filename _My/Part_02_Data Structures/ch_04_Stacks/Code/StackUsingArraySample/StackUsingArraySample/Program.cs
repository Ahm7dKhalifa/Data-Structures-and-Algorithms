using StackUsingArraySample.Exceptions;
using System;

namespace StackUsingArraySample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
                Stack<int> Stack = new Stack<int>(3);
                Stack.Push(1);
                Stack.Push(2);
                Stack.Push(3);
                Stack.Push(4);
                */
                Stack<int> Stack = new Stack<int>(0);
                Stack.Pop();
               
            }
            catch(StackUnderFlowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (StackOverFlowException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
