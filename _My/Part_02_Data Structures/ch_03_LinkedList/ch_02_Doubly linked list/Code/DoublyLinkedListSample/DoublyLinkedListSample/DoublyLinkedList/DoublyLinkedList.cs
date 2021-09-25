using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedListSample
{
    public class DoublyLinkedList<T>
    {
        public Node<T> Header { get; set; }
        public Node<T> Tail { get; set; }

        int Count = 0;

        public DoublyLinkedList()
        {
            
        }

        #region Operations

        #region Insert Operations
        public Node<T> InsertNewNodeAtFirst(T data)
        {
            Node<T> NewNode = CreateNewNode(data);
            
            if (IsLinkedListIsEmpty())
            {
                Header = NewNode;
                Tail = NewNode;
                NewNode.Previous = null;
                NewNode.Next = null;
            }
            else
            {
                Node<T> currentFirstNode = GetFirstNode();
                NewNode.Next = currentFirstNode;
                currentFirstNode.Previous = NewNode;
                Header = NewNode;
            }

            this.Count++;
            Console.WriteLine("The New Node Inserted At First With Data : " + data);
            return NewNode;
        }

        public Node<T> InsertNewNodeAfter(Node<T> previousNode, T dataOfNewNode)
        {
            Node<T> NewNode = CreateNewNode(dataOfNewNode);
            NewNode.Next = previousNode.Next;
            NewNode.Previous = previousNode;
            previousNode.Next = NewNode;
            NewNode.Next.Previous = NewNode;

            this.Count++;
            Console.WriteLine("The New Node Inserted After Node With Data : " + dataOfNewNode);
            return NewNode;
        }

        public Node<T> InsertNewNodeBefore(Node<T> nextNode, T dataOfNewNode)
        {
            Node<T> NewNode = CreateNewNode(dataOfNewNode);
            NewNode.Next = nextNode;
            NewNode.Previous = nextNode.Previous;
            nextNode.Previous = NewNode;
            NewNode.Previous.Next = NewNode;

            this.Count++;
            Console.WriteLine("The New Node Inserted After Node With Data : " + dataOfNewNode);
            return NewNode;
        }

        public Node<T> InsertNewNodeAtLast(T data)
        {
            if (IsLinkedListIsEmpty())
            {
               return InsertNewNodeAtFirst(data);
            }
            else
            {
                Node<T> newLastNode = CreateNewNode(data);
                Node<T> currentLastNode = GetLastNode();
                currentLastNode.Next = newLastNode;
                newLastNode.Previous = currentLastNode;
                Tail = newLastNode;
                this.Count++;
                Console.WriteLine("The New Node Inserted At Last With Data : " + data);
                return newLastNode;
            }        
        }

        #endregion

        #region Delete Operations
        public Node<T> DeleteNodeAtFirst()
        {
            Node<T> firstNode = GetFirstNode();
            if(!IsLinkedListIsEmpty())
            {
                if (IsLinkedListContainOnlyOneNode())
                {
                    Header = Tail = null;
                    firstNode.Previous = firstNode.Next = null;
                }
                else
                {
                    Node<T> secondNode = firstNode.Next;
                    Header = secondNode;
                    secondNode.Previous = null;
                    firstNode.Next = null;
                }
                this.Count--;
                Console.WriteLine("The Node At First Is Deleted Successfully... ");
            }
            return firstNode;
        }

        public Node<T> DeleteNodeAtLast()
        {
            if (!IsLinkedListIsEmpty())
            {
                if (IsLinkedListContainOnlyOneNode())
                {
                    var firstNode = DeleteNodeAtFirst();
                    return firstNode;
                }
                else
                {
                    Node<T> LastNode = GetLastNode();
                    Node<T> SecondLastNode = LastNode.Previous;
                    if (SecondLastNode != null)
                    {
                        Tail = SecondLastNode;
                        SecondLastNode.Next = null;
                        LastNode.Previous = null;
                        this.Count--;
                        Console.WriteLine("The Node At Last Is Deleted Successfully... ");   
                    }
                    return LastNode;
                }             
            }
            else
            {
                return null;
            }
        }

        public Node<T> DeleteThisNode(Node<T> currentNode)
        {
            if (IsFirstNode(currentNode))
                return DeleteNodeAtFirst();

            if (IsLastNode(currentNode))
                return DeleteNodeAtLast();

            Node<T> previousNode = currentNode.Previous;
            Node<T> nextNode = currentNode.Next;

            previousNode.Next = nextNode;
            nextNode.Previous = previousNode;
           
            currentNode = null;
            this.Count--;
           
            Console.WriteLine("The Node Is Deleted Successfully... ");
            return currentNode;
        }

        #endregion

        #region Read Operations
        public void TraverseFromHeaderToTail()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Linked List Items :");

            if (!IsLinkedListIsEmpty())
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


        public void TraverseFromTailToHeader()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Linked List Items :");

            if (!IsLinkedListIsEmpty())
            {

                Node<T> currentNode = GetLastNode();
                //Console.WriteLine(currentNode.Data);
                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.Data);
                    currentNode = currentNode.Previous;
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
            return Header;
        }

        private Node<T> GetLastNode()
        {
            return Tail;
        }

        private Node<T> GetThePreviousNode(Node<T> currentNode)
        {
            if (!IsLinkedListContainOnlyOneNode())
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

        private Node<T> GetThePreviousNodeOfCurrentLastNode()
        {
          Node<T> lastNode = Tail;
          return  lastNode.Previous;
        }

        #endregion

        #region Search
        public Node<T> FindFirstNodeContain(T value)
        {
            Node<T> currentNode = GetFirstNode();

            while(currentNode != null)
            {
                //if (currentNode.Data == value)
                if (EqualityComparer<T>.Default.Equals(currentNode.Data, value))
                    return currentNode;
                else
                    currentNode = currentNode.Next;
            }

            return null;
        }
        #endregion

        #region Shared Functions
        private Node<T> CreateNewNode(T data)
        {
            return new Node<T>(data);
        }

        private bool IsLinkedListIsEmpty()
        {
            if (Count <= 0)
                return true;
            else
                return false;
            /*
            if (Header == null)
                return true;
            else
                return false;
            */
        }
        private bool IsLinkedListContainOnlyOneNode()
        {
            Node<T> FirstNode = GetFirstNode();
            if(FirstNode != null && FirstNode.Next == null)
                return true;
            else
                return false;
        }
        private bool IsFirstNode(Node<T> currentNode)
        {
            return Header == currentNode; 
        }
        private bool IsLastNode(Node<T> currentNode)
        {
            return Tail == currentNode;
        }

        #endregion

        #endregion


    }
}



