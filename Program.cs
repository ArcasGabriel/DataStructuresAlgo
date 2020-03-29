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
using DataStructuresAlgo.dictionary;
using DataStructuresAlgo.binarytree;
using DataStructuresAlgo.avltrees;
using DataStructuresAlgo.heaps;
using DataStructuresAlgo.sorting;
using DataStructuresAlgo.searching;

namespace DataStructuresAlgo
{
    class Program
    {
        static void Main(string[] args)
        {   
            var sorter = new InsertionSort();
            var numbers = new int[6] {8,2,4,1,3,10};
            var numbers_unsorted = new int[6] {8,2,4,1,3,10};
            // Do binary searching on sorted array
            var searching = new BinarySearch();
            var found_at_index = searching.Search(10,sorter.sort(numbers));
            // Do linear searching on unsorted array
            var linear_searching = new LinearSearch(numbers_unsorted);
            var found_at_index_linear = linear_searching.Searching(10);
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
