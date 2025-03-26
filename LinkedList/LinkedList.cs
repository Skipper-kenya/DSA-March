using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTA.

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
            First = newNode.Next;
            First = newNode;
        }

        //iteration of the linked list

        public void DisplayList ()
        {
            Node Current = First;
            while (Current != null)
            {
                Current.DisplayNode();
                Current = Current.Next;
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
    }
}
