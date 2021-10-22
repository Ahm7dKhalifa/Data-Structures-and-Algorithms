using StackUsingArraySample.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackUsingArraySample
{
    public class Stack<T>
    {
        T[] Array;
        int Top = -1;

        public Stack(int arraySize = 10)
        {
            Array = new T[arraySize];
        }

        public void Push(T newElement)
        {
            if (IsStackFull())
            {
                throw new StackOverFlowException("Stack Is Full Exception");
            }

            Top++;
            Array[Top] = newElement;
            
        }
        public T Pop()
        {
            if (IsStackEmpty())
            {
                throw new StackUnderFlowException("Stack Is Empty Exception");
            }
           
            T lastElement = Array[Top];
            Top--;
            return lastElement;    
        }
        public T Peek()
        {
            if (IsStackEmpty())
            {
                throw new StackUnderFlowException("Stack Is Empty Exception");
            }

            return Array[Top];
        }
        private bool IsStackFull()
        {
            return Top >= Array.Length - 1;
        }
        private bool IsStackEmpty()
        {
            return Top == -1;
        }
    }
}
