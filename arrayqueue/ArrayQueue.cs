using System;
namespace DataStructuresAlgo
{
    public class ArrayQueueCustom
    {
        private int[] numbers = new int[5];
        private int front_index = 0;
        private int rear_index = 0;

        public ArrayQueueCustom(int capacity)
        {
            this.numbers = new int[capacity];
        }

        public void Enqueue(int item) {
            if (IsFull()) throw new OverflowException();
            numbers[rear_index] = item;
            rear_index = (rear_index + 1) % numbers.Length;
        }

        public int Dequeue() {
            if (IsEmpty()) throw new InvalidOperationException();
            var dequed_item = numbers[front_index];
            numbers[front_index] = 0;
            front_index = (front_index + 1 ) % numbers.Length;
            return dequed_item;
        }

        public bool IsFull() {
            return rear_index == numbers.Length;
        }

        public bool IsEmpty() {
            return rear_index == front_index;
        }

        public int Peek() {
            return numbers[rear_index];
        }

        public void Print() {
            for(int i=front_index;i<rear_index;i++) {
                System.Console.WriteLine(numbers[i]);
            }
        }


    }
}