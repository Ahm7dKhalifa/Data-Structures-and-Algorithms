using System;

namespace SinglyLinkedListSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //SinglyLinkedList<int> linkedList = new SinglyLinkedList<int>();
            //linkedList.InsertNewNodeAtFirst(1);
            //linkedList.InsertNewNodeAtLast(2);
            //linkedList.InsertNewNodeAtLast(3);
            //linkedList.Traverse();

            //SinglyLinkedList<int> linkedList2 = new SinglyLinkedList<int>();
            //linkedList2.InsertNewNodeAtLast(1);
            //linkedList2.InsertNewNodeAtLast(2);
            //linkedList2.InsertNewNodeAtLast(3);
            //linkedList2.Traverse();

            //SinglyLinkedList<int> linkedList3 = new SinglyLinkedList<int>();
            //linkedList3.InsertNewNodeAtFirst(2);
            //linkedList3.InsertNewNodeAtLast(3);
            //linkedList3.InsertNewNodeAtFirst(1);
            //linkedList3.InsertNewNodeAtLast(4);
            //linkedList3.Traverse();
            //linkedList3.DeleteTheNodeAtFirst();
            //linkedList3.DeleteTheNodeAtFirst();
            //linkedList3.DeleteTheNodeAtFirst();
            //linkedList3.DeleteTheNodeAtFirst();
            //linkedList3.DeleteTheNodeAtFirst();
            //linkedList3.Traverse();

            //SinglyLinkedList<int> linkedList4 = new SinglyLinkedList<int>();
            //Node<int> nodeOne = linkedList4.InsertNewNodeAtFirst(1);
            //Node<int> nodeTwo = linkedList4.InsertNewNodeAtLast(2);
            //Node<int> nodeThree = linkedList4.InsertNewNodeAtLast(3);
            //Node<int> nodeFive = linkedList4.InsertNewNodeAtLast(5);
            //Node<int> nodeSex = linkedList4.InsertNewNodeAtLast(6);
            //Node<int> nodeFour = linkedList4.InsertNewNodeAfter(nodeThree,4);
            //linkedList4.Traverse();
            //linkedList4.DeleteTheNodeAtFirst();
            //linkedList4.DeleteTheNodeAtFirst();
            //linkedList4.Traverse();
            //linkedList4.DeleteTheNodeAtLast();
            //linkedList4.DeleteTheNodeAtLast();
            //linkedList4.DeleteTheNodeAtLast();
            //linkedList4.DeleteTheNodeAtLast();
            //linkedList4.DeleteTheNodeAtLast();
            //linkedList4.Traverse();

            //SinglyLinkedList<int> linkedList5 = new SinglyLinkedList<int>();
            //linkedList5.InsertNewNodeAtFirst(2);
            //linkedList5.InsertNewNodeAtLast(3);
            //linkedList5.InsertNewNodeAtFirst(1);
            //linkedList5.InsertNewNodeAtLast(4);
            //linkedList5.Traverse();
            //linkedList5.DeleteTheNodeAtPosition(2);
            //linkedList5.Traverse();
            //linkedList5.DeleteTheNodeAtPosition(1);
            //linkedList5.Traverse();
            //linkedList5.DeleteTheNodeAtPosition(1);
            //linkedList5.Traverse();
            //linkedList5.DeleteTheNodeAtPosition(0);
            //linkedList5.Traverse();

            SinglyLinkedList<int> linkedList5 = new SinglyLinkedList<int>();
            Node<int> nodeOne = linkedList5.InsertNewNodeAtFirst(1);
            Node<int> nodeTwo = linkedList5.InsertNewNodeAtLast(2);
            Node<int> nodeThree = linkedList5.InsertNewNodeAtLast(3);
            Node<int> nodeFive = linkedList5.InsertNewNodeAtLast(5);
            Node<int> nodeSex = linkedList5.InsertNewNodeAtLast(6);
            Node<int> nodeFour = linkedList5.InsertNewNodeAfter(nodeThree, 4);
            linkedList5.Traverse();
            linkedList5.DeleteThisNode(nodeFive);
            linkedList5.Traverse();
            linkedList5.DeleteThisNode(nodeFour);
            linkedList5.Traverse();
            linkedList5.DeleteThisNode(nodeSex);
            linkedList5.Traverse();
            linkedList5.DeleteThisNode(nodeTwo);
            linkedList5.Traverse();
            linkedList5.DeleteThisNode(nodeOne);
            linkedList5.Traverse();
            linkedList5.DeleteThisNode(nodeThree);
            linkedList5.Traverse();
        }
    }
}
