using StackUsingLinkedlistSample.Exceptions;
using System;

namespace StackUsingLinkedlistSample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stack<int> Stack = new Stack<int>();
                //Stack.Pop();
                //Stack.Peek();
                Stack.Push(1);
                Stack.Push(2);
                Stack.Push(3);
                //Stack.Push(4);
                Console.WriteLine(Stack.Peek());
                Console.WriteLine(Stack.Pop());
                Console.WriteLine(Stack.Pop());
                Console.WriteLine(Stack.Pop());
            }
            catch (StackUnderFlowException ex)
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
