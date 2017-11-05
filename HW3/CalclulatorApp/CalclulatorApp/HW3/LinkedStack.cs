using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalclulatorApp.HW3
{
public class LinkedStack : IStackADT
    {
        private Node top;

        ///This is the constructor of the linkedstack
        ///
        ///Param: NA
        ///Returns: NA
        public LinkedStack()
        {
            top = null;
        }

        ///Push values onto the top of the stack.
        ///Note: that they must be non-NULL types.
        ///
        ///Param: object type of (newItem) which is then added to the stack/list.
        ///Returns: object newItem, which was added to the stack/list.
        
        public object Push(object newItem)
        {
            if(newItem == null)
            {
                return null;
            }

            Node newNode = new Node(newItem, top);
            top = newNode;
            return newItem;
        }

        ///Pop the values of the stack/list.
        ///
        ///Param: NA
        ///Retruns: The object at the top of the stack/list 
        public object Pop()
        {
            if (IsEmpty())
            {
                return null;
            }
            object topItem = top.data;
            top = top.Next;
            return topItem;
        }

        /// This is the 
        /// 
        /// </summary>
        /// <returns></returns>
        public object Peek()
        {
            if (IsEmpty())
            {
                return null;
            }
            return top.data;
        }

        /// Check to see if the stack is Empty.
        /// 
        /// Param: NA
        /// Returns: bool, True if it empty else it will be false.
        public bool IsEmpty()
        {
            return top == null;
        }

        /// Clears the stack of all elements that is being held by nodes in the stack.
        /// 
        /// Param: NA
        /// Retruns: void
        public void Clear()
        {
            top = null;
        }
    }
}