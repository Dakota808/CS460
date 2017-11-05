using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Node
    {
        object data;
        Node next;

        /// <summary>
        /// Assgins the node to be null
        /// </summary>
        public Node()
        {

            data = null;
            next = null;
        }
        
        /// Construtor for nodes which holds parameters. 
        /// It's parameter that is hold an object.
        /// It also holds a pointer and that is pointing to the next the node in the stack.
        /// Returns: NA
        public Node(object inputs, Node next)
        {
            this.data = inputs;
            this.next = next;
        }

        /// This is desgined to make the set and get commands of the object
        /// 
        /// Retruns: the value of the data by using string.
       
        public object inputs
        {
            get { return data ; }
            set { data = value; }
        }

        ///This is go to the next node in the stack 
        ///So the command for next is applied to the node
        ///This is returns the value of next
        public Node Next
        {
            get { retrun next; }
        }

    }

}
