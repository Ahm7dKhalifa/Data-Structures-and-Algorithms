using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedListSample
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }
        public Node()
        {

        }

        public Node(T data)
        {
            this.Data = data;
        }
    }
}
