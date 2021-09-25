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
            DoublyLinkedList.TraverseFromHeaderToTail();
            var nodeWithValue6 = DoublyLinkedList.InsertNewNodeAtLast(6);
            DoublyLinkedList.InsertNewNodeAtLast(7);
            DoublyLinkedList.TraverseFromHeaderToTail();
            DoublyLinkedList.InsertNewNodeAfter(nodeWithValue3,4);
            DoublyLinkedList.InsertNewNodeBefore(nodeWithValue6, 5);
            DoublyLinkedList.TraverseFromHeaderToTail();

            DoublyLinkedList.DeleteNodeAtFirst();
            DoublyLinkedList.DeleteNodeAtLast();
            DoublyLinkedList.DeleteThisNode(nodeWithValue3);
            DoublyLinkedList.TraverseFromHeaderToTail();
            DoublyLinkedList.TraverseFromTailToHeader();
            DoublyLinkedList.DeleteNodeAtLast();
            DoublyLinkedList.DeleteNodeAtLast();
            DoublyLinkedList.DeleteNodeAtLast();
            DoublyLinkedList.DeleteNodeAtLast();
            DoublyLinkedList.DeleteNodeAtLast();
            DoublyLinkedList.DeleteNodeAtLast();
            DoublyLinkedList.TraverseFromHeaderToTail();

        }
    }
}
