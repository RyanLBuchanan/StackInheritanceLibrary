using LinkedListLibrary;
using System.Collections.Generic;

namespace StackInheritanceLibrary
{
    public class StackInheritance : List
    {
        // Pass name "stack" to List constructor
        public StackInheritance() : base("stack") { }

        // Place ditem from dataValue at top of stack by inserting
        // dataValue at front of linked list
        public void Push(object dataValue)
        {
            InsertAtFront(dataValue);
        }

        // Remove item from top of stack by removing
        // item at front of linked list

        public object Pop()
        {
            return RemoveFromFront();
        }
    }
}