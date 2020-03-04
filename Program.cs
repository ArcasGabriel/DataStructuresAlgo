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

namespace DataStructuresAlgo
{
    class Program
    {
        static void Main(string[] args)
        {   
            var stack_custom = new StackQueueCustom();
            stack_custom.Enqueue(10);
            stack_custom.Enqueue(20);
            stack_custom.Enqueue(30);
            stack_custom.Print();


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
