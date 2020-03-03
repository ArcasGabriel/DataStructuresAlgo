using System;
namespace DataStructuresAlgo.stack
{
    public class StackSimple
    {
        private int[] numbers= new int[5];

        private int count=0;

        public void Push(int item) {
            if(count == numbers.Length)
                throw new OverflowException();
            numbers[count++] = item;
        }


        public int Peek() {
            return numbers[count-1];
        }

        public int Pop() {
            return numbers[--count];
        }

        public bool isEmpty() {
            return count == 0;
        }

        public void print() {
            for(int i=0;i<count;i++){
                System.Console.Write(numbers[i]);
            }
        }
    }
}