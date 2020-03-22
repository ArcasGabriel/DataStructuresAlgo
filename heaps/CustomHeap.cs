using System;
namespace DataStructuresAlgo.heaps
{
    public class CustomHeap
    {
        private int[] numbers = new int[10];
        private int count=0;

        public void insert(int item) {
            isFull();
            numbers[count++] = item;
            bubbleUp();
        }

        public int delete() {
            isEmpty();
            numbers[0] = numbers[--count];
            var root = numbers[0];
            var index = 0;
            while(index >= 0 && !isValidParent(index)) {
                var largerChildIndexVal = largerChildIndex(index);
                swap(ref index, ref largerChildIndexVal);
                index = largerChildIndexVal;
            }
            return root;
        }

        public int largerChildIndex(int index) {
            if(!hasLeftChild(index))
                return index;
            if(!hasRightChild(index))
                return numbers[leftChild(index)];

            var largerChildIndex = 
                (numbers[leftChild(index)] > numbers[rightChild(index)])? 
                numbers[leftChild(index)]: numbers[rightChild(index)];
                swap(ref index, ref largerChildIndex);
            return largerChildIndex;
        }

        public bool isValidParent(int index){
            if(!hasLeftChild(index)) {
                return true;
            }

            if(!hasRightChild(index)) {
                return numbers[index] >= numbers[leftChild(index)]; 
            }


            return numbers[index] >= numbers[leftChild(index)] && numbers[index] >= numbers[rightChild(index)];
        }

        public bool hasLeftChild(int index) {
            return leftChild(index) <= 0;
        }

        public bool hasRightChild(int index) {
            return rightChild(index) <= 0;
        }

        public int leftChild(int index) {
            return index * 2 + 1; 
        }

        public int rightChild(int index) {
            return index * 2 + 2;
        }

        
        public void isEmpty() {
            if(count == 0)
                throw new InvalidOperationException();
        }

        public void isFull() {
            if(count == numbers.Length)
                throw new InvalidOperationException();
        }

        public int parent_index(int index) {
            return (index - 1) / 2;
        }


        public void bubbleUp() {
            var index = count - 1;
            while(index > 0 && numbers[index] > numbers[parent_index(index)]) {
                var parent_index_val = parent_index(index);
                swap(ref index, ref parent_index_val);
                index = parent_index(index);
            }
        }

        public void swap(ref int first, ref int second) {
            int temp = numbers[first];
            numbers[first] = numbers[second];
            numbers[second] = temp;
        }


    }
}