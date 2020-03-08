﻿using System.Collections;
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

            var sentence = "green apple";
            findFirstRepeteadWord(sentence);

        }

        public static void findFirstRepeteadWord(string sentence) {
            var set = new HashSet<char>();
            foreach(var item in sentence) {
                if(set.Contains(item)) {
                    System.Console.WriteLine("First repeated character is {0}", item);
                    break;
                }
                set.Add(item);                
            }
        }

        public static void findFirstWord(string sentence) {
             var dictionary = new Dictionary<char,int>();
             
             foreach(var item in sentence) {
                 if(!(dictionary.ContainsKey(key: item))) {
                 dictionary.Add(key: item,value:1);
                 }
                 else {
                     var count = dictionary[item];
                     dictionary.Remove(item);
                     dictionary.Add(key:item, value:++count);
                 }
             }
             foreach(var item in dictionary) {
                 if (item.Value == 1) {
                     System.Console.WriteLine("FIRST UNREPEATED WORD {0}", item);
                     break;
                 }
             }   
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
