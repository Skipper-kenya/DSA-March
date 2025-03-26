using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTA.LinkedList
{
    public class LinkedList
    {
        public Node? First { get; set; }

        //inserts a new node to a linked list

        public void insertFirst(int data)
        {
            //create a node
            Node newNode = new Node();
            //assign data to the new node
            newNode.Data = data;
            //assing new head to the next node
            newNode.Next = First;
            First = newNode;
        }

        //iteration of the linked list

        public void DisplayList ()
        {
            Node current = First;
            while (current != null)
            {
                current.DisplayNode();
                current = current.Next;
            }
        }

        //deletes the first node

        public Node DeleteFirst()
        {
            //assign temporary variable to the first node
            Node temp = First;
            //assign new head
            First = First.Next;
           
            return temp;
        }

        public void InsertLast(int data)
        {
            Node current = First;
            while(current.Next != null)
            {
                current = current.Next;
            }

            Node newNode = new Node();
            newNode.Data = data;

            current.Next = newNode;
        }

    }
}
