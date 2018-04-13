﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListLibrary
{
    public class ListNode<T>
    {
        public T Data { get; private set; }

        public ListNode<T> Next { get; set; }

        // constructor to create ListNode that refers to dataValue
        // and is last node in list
        public ListNode(T dataValue): this(dataValue, null){}
      
         // constructor to create ListNode that refers to dataValue
        // and refers to next ListNode in List
        public ListNode(T dataValue, ListNode<T> nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        } // end constructor
    } // end class ListNode
}
