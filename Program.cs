using System.Collections;
using System.Text;
using System.Collections.Generic;
using System;
using DataStructuresAlgo.array;
using DataStructuresAlgo.linkedlist;
using DataStructuresAlgo.reversestring;
using DataStructuresAlgo.balancedexpressions;
using DataStructuresAlgo.stack;
using DataStructuresAlgo.StackQueue;
using DataStructuresAlgo.priorityqueue;

namespace DataStructuresAlgo
{
    class Program
    {
        static void Main(string[] args)
        {   
            var priority_queue = new PriorityQueue();
            priority_queue.insert(1);
            priority_queue.insert(3);
            priority_queue.insert(5);
            priority_queue.insert(2);
            priority_queue.insert(7);
            priority_queue.insert(8);
            priority_queue.insert(9);
            priority_queue.insert(6);


             

        }

        public static void reverse(ref Queue<int> queue) {
            var new_stack = new Stack<int>();
            while(!(queue.Count == 0)) {
                new_stack.Push(queue.Dequeue());
            }
            while(!(new_stack.Count == 0)) {
                queue.Enqueue(new_stack.Pop());
            }
        }

        public static void print(Queue<int> queue) {
            foreach(var item in queue)
                System.Console.WriteLine(item);
                System.Console.WriteLine("END");
        }
    }
}
