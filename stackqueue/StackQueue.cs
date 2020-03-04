using System.Collections.Generic;
namespace DataStructuresAlgo.StackQueue
{
    public class StackQueueCustom
    {
        Stack<int> numbers = new Stack<int>();

        public void Enqueue(int item) {
            numbers.Push(item);
        }
        // [10,20,30]
        // 
        public void Dequeue() {
            var new_stack = new Stack<int>();
        }

        public void Print(){
            foreach(var number in numbers)
                System.Console.WriteLine(number);
        }
    }
}