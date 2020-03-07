using System.Collections.Generic;
namespace DataStructuresAlgo.StackQueue
{
    public class StackQueueCustom
    {
        Stack<int> enq = new Stack<int>();
        Stack<int> deq = new Stack<int>();
        public void Enqueue(int item) {
            enq.Push(item);
        }
        public int Dequeue() {
            if (IsEmpty()) {
                throw new System.ArgumentException();
            }
            if (deq.Count == 0) {
                while(enq.Count > 0) {
                    deq.Push(enq.Pop());
                }
            }
            return deq.Pop();
        }

        public bool IsEmpty() {
            return (enq.Count == 0 && deq.Count == 0);
        }
    }
}