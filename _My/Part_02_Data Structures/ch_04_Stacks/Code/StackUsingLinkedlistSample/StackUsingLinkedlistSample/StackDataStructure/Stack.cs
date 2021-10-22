
using StackUsingLinkedlistSample.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackUsingLinkedlistSample
{
    public class Stack<T>
    {
        LinkedList<T> LinkedList = new LinkedList<T>();
        
        public void Push(T newElement)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(newElement);
            LinkedList.AddFirst(newNode);
        }

        public T Pop()
        {
            if (IsStackEmpty())
            {
                throw new StackUnderFlowException("Stack Is Empty Exception");
            }

            T elementValue = LinkedList.First.Value;
            LinkedList.RemoveFirst();
            return elementValue;
        }

        public T Peek()
        {
            if (IsStackEmpty())
            {
                throw new StackUnderFlowException("Stack Is Empty Exception");
            }
            return LinkedList.First.Value;
        }
       
        private bool IsStackEmpty()
        {
            return LinkedList.Count == 0;
        }
    }
}
