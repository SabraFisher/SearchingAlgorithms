using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms
{
    // is the individual "element" of a linked list - AKA The data
    public class Node
    {
        // payload - Aka the data
        public string data;

        // pointer - the next piece of data
        public Node next;

        //could have another pointer to point at the last piece of data

        // constructor
        public Node(string value)
        {
            data = value;
        }

        public Node(string value, Node next)
        {
            data = value;
            next = next;
        }
    }
}