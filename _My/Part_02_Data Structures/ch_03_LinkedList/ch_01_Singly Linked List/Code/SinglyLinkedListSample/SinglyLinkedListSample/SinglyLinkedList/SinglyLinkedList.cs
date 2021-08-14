using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkedListSample
{
    public class SinglyLinkedList<T>
    {
        public Node<T> Header { get; set; }
        public Node<T> Tail { get; set; }

        int Count = 0;

        public SinglyLinkedList()
        {
            Header = new Node<T>();
            Tail = new Node<T>();
        }

        #region Operations

        #region Insert Operations
        public Node<T> InsertNewNodeAtFirst(T data)
        {
            Node<T> NewNode = CreateNewNode(data);
            
            if (!CheckIfLinkedListIsEmpty())
            {
                Node<T> currentFirstNode = GetFirstNode();
                NewNode.Next = currentFirstNode;
                Header.Next = NewNode;
            }
            else
            {
                Header.Next = NewNode;
                Tail.Next = NewNode;
            }

            this.Count++;
            Console.WriteLine("The New Node Inserted At First With Data : " + data);
            return NewNode;
        }

        public Node<T> InsertNewNodeAfter(Node<T> previousNode, T dataOfNewNode)
        {
            Node<T> NewNode = CreateNewNode(dataOfNewNode);
            NewNode.Next = previousNode.Next;
            previousNode.Next = NewNode;
            this.Count++;
            Console.WriteLine("The New Node Inserted After Node With Data : " + dataOfNewNode);
            return NewNode;
        }

        public Node<T> InsertNewNodeAtLast(T data)
        {
            if (CheckIfLinkedListIsEmpty())
            {
               return InsertNewNodeAtFirst(data);
            }
            else
            {
                Node<T> newLastNode = CreateNewNode(data);
                Node<T> currentLastNode = GetLastNode();
                currentLastNode.Next = newLastNode;
                Tail.Next = newLastNode;
                this.Count++;
                Console.WriteLine("The New Node Inserted At Last With Data : " + data);
                return newLastNode;
            }        
        }

        #endregion


        #region Delete Operations
        public Node<T> DeleteTheNodeAtFirst()
        {
            Node<T> firstNode = GetFirstNode();
            if(firstNode != null)
            {
                Header.Next = firstNode.Next;
                firstNode.Next = null;
                this.Count--;
                Console.WriteLine("The Node At First Is Deleted Successfully... ");
            }

            return firstNode;
        }

        public Node<T> DeleteTheNodeAtLast()
        {
            if (CheckIfLinkedListContainOnlyOneNode())
            {
               var firstNode = DeleteTheNodeAtFirst();
                Header.Next = null;
                Tail.Next = null;
                this.Count--;
                return firstNode;
            }

            Node<T> TheNodeBeforeCurrentLastNode = GetTheNodeBeforeCurrentLastNode();
            if (TheNodeBeforeCurrentLastNode != null)
            {
                Tail.Next = TheNodeBeforeCurrentLastNode;
                TheNodeBeforeCurrentLastNode.Next = null;
                this.Count--;
                Console.WriteLine("The Node At Last Is Deleted Successfully... ");
            }

            return TheNodeBeforeCurrentLastNode;
        }

        public Node<T> DeleteThisNode(Node<T> currentNode)
        {
            if (IsFirstNode(currentNode))
                return DeleteTheNodeAtFirst();

            if (IsLastNode(currentNode))
                return DeleteTheNodeAtLast();

            Node<T> TheNodePrevious = GetThePreviousNode(currentNode);
            Node<T> TheNodeAfter = TheNodePrevious.Next.Next;

            TheNodePrevious.Next = TheNodeAfter;
            currentNode = null;
            this.Count--;
            Console.WriteLine("The Node Is Deleted Successfully... ");
            return currentNode;
        }

        public Node<T> DeleteTheNodeAtPosition(int position)
        {
            if (position == 0)
                return DeleteTheNodeAtFirst();

            if(position == Count - 1)
                return DeleteTheNodeAtLast();

            Node<T> TheNodePreviousThisPosition = GetTheNodeAtPosition(position - 1);
            Node<T> TheCurrentNode = TheNodePreviousThisPosition.Next;
            Node<T> TheNodeAfterThisPosition = TheNodePreviousThisPosition.Next.Next;

            TheNodePreviousThisPosition.Next = TheNodeAfterThisPosition;
            TheCurrentNode = null;
            this.Count--;
            Console.WriteLine("The Node At Position : " + position + " Is Deleted Successfully... ");
            return TheCurrentNode;
        }

        #endregion

        #region Read Operations
        public void Traverse()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Linked List Items :");

            if (!CheckIfLinkedListIsEmpty())
            {

                Node<T> currentNode = GetFirstNode();
                //Console.WriteLine(currentNode.Data);
                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.Data);
                    currentNode = currentNode.Next;
                }

            }

            Console.WriteLine("End");
            Console.WriteLine("---------------------------------------");
        }


        public Node<T> GetTheNodeAtPosition(int position)
        {
            Node<T> currrentNode = GetFirstNode();

            if (position < this.Count)
            {
                for (int i = 0; i <= position; i++)
                {
                    currrentNode = currrentNode.Next;
                }
            }

            if (currrentNode != null)
            {
                Console.WriteLine("The Node At Position : " + position + " Has Data : " + currrentNode.Data);
            }
            else
            {
                Console.WriteLine("There Is No Node At Position : " + position);
            }

            return currrentNode;
        }
        private Node<T> GetFirstNode()
        {
            return Header.Next;
        }

        private Node<T> GetLastNode()
        {
            return Tail.Next;
        }

        private Node<T> GetThePreviousNode(Node<T> currentNode)
        {
            if (!CheckIfLinkedListContainOnlyOneNode())
            {
                Node<T> ThePreviousNode = GetFirstNode();

                while (ThePreviousNode.Next != currentNode)
                {
                    ThePreviousNode = ThePreviousNode.Next;
                }

                return ThePreviousNode;
            }

            return null;
        }

        private Node<T> GetTheNodeBeforeCurrentLastNode()
        {
            Node<T> TheNodeBeforeCurrentLastNode = null;
            Node<T> currentNode = GetFirstNode();

            if (currentNode == null || currentNode.Next == null)
                return currentNode;

            while (currentNode.Next != null && currentNode.Next.Next != null)
            {
                currentNode = currentNode.Next;
            }

            TheNodeBeforeCurrentLastNode = currentNode;
            
            return TheNodeBeforeCurrentLastNode;
        }
      
        #endregion
        private Node<T> CreateNewNode(T data)
        {
            return new Node<T>(data);
        }

        private bool CheckIfLinkedListIsEmpty()
        {
            if (Header.Next == null)
                return true;
            else
                return false;
        }
        private bool CheckIfLinkedListContainOnlyOneNode()
        {
            if (Header.Next != null && Header.Next.Next != null)
                return false;
            else
                return true;
        }

        private bool IsFirstNode(Node<T> currentNode)
        {
            return Header.Next == currentNode; 
        }

        private bool IsLastNode(Node<T> currentNode)
        {
            return Tail.Next == currentNode;
        }
        #endregion

    }
}


