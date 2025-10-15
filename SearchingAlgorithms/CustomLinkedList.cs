using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SearchingAlgorithms
{
    public class CustomLinkedList
    {
        // this is the linked list container - Represents the whole list

        // THE MOST IMPORTANT - do not lose this ever
        private Node head;

        public CustomLinkedList()
        {
            head = null;
        }

        public CustomLinkedList(string value)
        {
            head = new Node(value);
        }


        // add a new node to the end list
        public void AddToBack(string value)
        {
            Node obj = new Node(value);

            // is head null, if so insert @ head
            if (head == null)
            {
                head = obj;
                return;
            }

            // start at the head
            Node pos = head;

            // loop until i get to the end of the list
            while (pos.next != null)
            {
                pos = pos.next;
            }

            // add the new node there
            pos.next = obj;
        }

        // add to front
        public void AddToFront(string value)
        {
            Node oldHead = head; // bookmarking it
            head = new Node(value); // replacing it
            head.next = oldHead; // putting the rest of the list back in line
        }

        // insert alphabetically
        public void Add(string value)
        {
            var obj = new Node(value);

            // head is empty, make new head
            if (head == null)
            {
                head = obj;
            }
            else // otherwise, walk along chain
            {
                Node previousNode = null; // keep track of previous node here
                Node currentNode = head; // keep track of current node here

                while (currentNode != null && currentNode.data.CompareTo(obj.data) < 0) // walk until current is null or value is equal or greater
                {
                    previousNode = currentNode;
                    currentNode = currentNode.next;
                }

                // we have our position, insert it
                if (previousNode == null) // if no previous node, insert as the head
                {
                    obj.next = head;
                    head = obj;
                }
                else // otherwise insert after the previous node and before the current node (insert in middle)
                {
                    obj.next = previousNode.next;
                    previousNode.next = obj;
                }
            }
        }

        public override string? ToString()
        {
            string result = "";
            Node pos = head;

            // head is empty, return nothing
            if (pos == null)
            {
                return result;
            }

            // head has contents, loop over it, printing the data
            while (pos != null)
            {
                result += pos.data;
                pos = pos.next;
            }

            return result;
        }

        // add something to the list at a specific position

        // remove something from the list at a specific position

        // to string the list

    }
}