using System;
using DataStructuresAlgo.array;
using DataStructuresAlgo.linkedlist;

namespace DataStructuresAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedlist_custom = new LinkedListCustom();
            linkedlist_custom.addFirst(10);
            linkedlist_custom.addFirst(20);
            linkedlist_custom.addFirst(30);
            linkedlist_custom.reverse();
            var item = linkedlist_custom.getKthNodeToEnd(2);


        }
    }
}
