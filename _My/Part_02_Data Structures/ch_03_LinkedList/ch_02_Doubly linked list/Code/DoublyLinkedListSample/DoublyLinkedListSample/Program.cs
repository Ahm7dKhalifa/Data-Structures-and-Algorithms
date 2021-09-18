using System;

namespace DoublyLinkedListSample
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> DoublyLinkedList = new DoublyLinkedList<int>();
            var nodeWithValue3 = DoublyLinkedList.InsertNewNodeAtFirst(3);
            DoublyLinkedList.InsertNewNodeAtFirst(2);
            DoublyLinkedList.InsertNewNodeAtFirst(1);
            DoublyLinkedList.Traverse();
            var nodeWithValue6 = DoublyLinkedList.InsertNewNodeAtLast(6);
            DoublyLinkedList.InsertNewNodeAtLast(7);
            DoublyLinkedList.Traverse();
            DoublyLinkedList.InsertNewNodeAfter(nodeWithValue3,4);
            DoublyLinkedList.InsertNewNodeBefore(nodeWithValue6, 5);
            DoublyLinkedList.Traverse();
        }
    }
}
