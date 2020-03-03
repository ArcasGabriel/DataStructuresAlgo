using System;
namespace DataStructuresAlgo.stack
{
    public class StackCustom
    {
        private int[] numbers;

        private int length;

        public StackCustom(int length)
        {
            this.numbers = new int[length];
        }

        public void Push(int item) {

            if(numbers.Length == length){
                var new_array = new int[length+1];
                for(int i=0;i<length;i++){ 
                    new_array[i] = numbers[i];
                } 
                numbers = new_array;
            }
            numbers[length++] = item;
        }


        public int Peek() {
            if(isEmpty()) return -1;
            return numbers[length-1]; 
        }

        public void Pop() {
            if (isEmpty()) throw new InvalidOperationException();
            var new_popped_array = new int[length-1];

            for(int i=0;i<length;i++) {
                if(numbers[i] != numbers[length-1])
                    new_popped_array[i] = numbers[i];
            }
            numbers = new_popped_array;
            length--;
        }

        public bool isEmpty() {
            return length == 0;
        }
    }
}