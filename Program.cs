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
            //linkedlist_custom.addFirst(value: 30);
            linkedlist_custom.addLast(value: 40);
            linkedlist_custom.addLast(value: 50);
            linkedlist_custom.addLast(value: 60);
            linkedlist_custom.addLast(value: 70);
            linkedlist_custom.addFirst(value: 30);
            linkedlist_custom.addFirst(value: 20);
            linkedlist_custom.addFirst(value: 10);
            linkedlist_custom.deleteLast();
            linkedlist_custom.addFirst(value: 5);
            var count = linkedlist_custom.size();
            var new_array = linkedlist_custom.toArray();


        }
    }
}
