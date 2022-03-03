using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_CollectionNamespace_Lesson18
{
    internal class SingleLinkedList
    {
        internal Node head;

        internal void InsertFront(Message newData)
        {
            Node newNode = new Node(newData);
            newNode.next = head;
            head = newNode;
        }

        internal void InsertLast(Message newData)
        {
            Node newNode = new Node(newData);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node lastNode = GetLastNode();
            lastNode.next = newNode;
        }

        internal void InsertAfter(Node prevNode, Message newData)
        {
            if (prevNode == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            Node new_node = new Node(newData);
            new_node.next = prevNode.next;
            prevNode.next = new_node;
        }

        internal Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
    }
}
