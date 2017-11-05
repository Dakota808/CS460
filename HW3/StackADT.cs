using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface IStackADT
    {
        ///This is used to push new objects onto the top of the stack.
        ///
        ///param: type object (new Item)
        ///This will create a new object of newItem and then push that object onto the stack.
        ///Returns: Object, which is the object that was pushed onto the stack.
        object Push(object newItem);

        ///This will pop the object off the top of the stack.
        ///Which this will return the the result.
        ///
        ///param: this will hold a null
        ///Retruns: object, which is the object in the top of the stack.
        object Pop();

        ///This looks at the top of the stack.
        ///It looks at what element is stored without popping the object off the stack. 
        ///
        ///param: this holds null
        ///Retruns: object, which will return what is at the top of the stack.
        object Peek();

        ///This will check to see if the stack is empty.
        ///
        ///param: holds null
        ///Returns: boolean, True if the stack is empty otherwise it will return false.

        bool IsEmpty();

        ///This just clears the stack.
        ///
        ///param: holds null
        ///Retruns: this holds the void method call.
        void Clear();
    }
}