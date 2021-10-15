using StackUsingArraySample.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackUsingArraySample
{
    public class Stack<T>
    {
        T[] StackArray;
        int TopIndex = 0;
        public Stack(int arraySize = 1000)
        {
            StackArray = new T[arraySize];
        }

        public void Push(T newElement)
        {
            if (IsStackFull())
            {
                throw new StackOverFlowException("Stack Is Full Exception ,, When You Try Inserted Value : " + newElement);
            }
            
            StackArray[TopIndex] = newElement;
            TopIndex++;
        }

        public T Pop()
        {
            if (IsStackEmpty())
            {
                throw new StackUnderFlowException("Stack Is Empty Exception");
            }
           
            T lastElement = StackArray[TopIndex];
            TopIndex--;
            return lastElement;
               
            
        }

        private bool IsStackFull()
        {
            return TopIndex == StackArray.Length;
        }

        private bool IsStackEmpty()
        {
            return TopIndex == 0;
        }
    }
}
