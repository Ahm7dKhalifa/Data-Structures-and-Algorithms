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
                Stack<int> Stack = new Stack<int>(3);
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
            catch(StackUnderFlowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (StackOverFlowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {

                Stack<int> Stack = new Stack<int>(3);
                Stack.Push(1);
                Stack.Push(2);
                Stack.Push(3);
                Stack.Push(4);
                

            }
            catch (StackUnderFlowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (StackOverFlowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {

                Stack<int> Stack = new Stack<int>(3);
                Stack.Pop();
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
