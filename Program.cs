using System.Text;
using System.Collections.Generic;
using System;
using DataStructuresAlgo.array;
using DataStructuresAlgo.linkedlist;
using DataStructuresAlgo.reversestring;
using DataStructuresAlgo.balancedexpressions;
using DataStructuresAlgo.stack;

namespace DataStructuresAlgo
{
    class Program
    {
        static void Main(string[] args)
        {   
            var stack_custom = new StackSimple();
            stack_custom.Push(10);
            stack_custom.Push(20);
            stack_custom.Push(30);
            stack_custom.Pop();
            stack_custom.Pop();
            stack_custom.print();

        }
    }
}
