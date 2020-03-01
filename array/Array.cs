using System;
using System.Xml.Linq;
using System.Linq;
namespace DataStructuresAlgo.array
{
    public class ArrayCustom
    {
        private int[] numbers;
        private int length;

        public ArrayCustom(int length)
        {
            this.numbers = new int[length];
        }

        public void insert(int item)
        {
            if(numbers.Length == length) {
                var newItems = new int[length * 2];
                for (int i=0;i<length;i++) {
                    newItems[i] = numbers[i];
                }
                numbers = newItems;
            }

            numbers[length++] = item;
            
        }
        
        public void removeAt(int index)
        {
            if (index < 0 || index >= length)
                throw new ArgumentException();
            
            for(int i = index; i < length; i++)
                numbers[i] = numbers[i+1];
            length--;
        }

        public int indexOf(int item)
        {
            int index=-1;
            for(int i=0; i<length; i++)
            {
                if (item == numbers[i])
                index = i;
            }
            return index;
        }

        public void print()
        {
           for(int i=0; i<length; i++) {
               System.Console.WriteLine(numbers[i]);
           }
        }

        public int max()
        {
            var max = 0;
            for (int i=0; i<length; i++)
            {
                if (numbers[i] > max)
                 max = numbers[i];
            }
            return max;
        }

        public int[] intersect(int[] to_compare)
        {
            var intersected_array = new int[length];
            int count_interesected = 0;
            for (int i=0; i<length; i++) {
                for (int j=0; j<to_compare.Length;j++) {
                    if (to_compare[j] == numbers[i]) {
                        intersected_array[count_interesected++] = to_compare[j];
                    }
                }
            }
            return intersected_array;
        }

        public void reverse() {
            var reverse_array = new int[length];
            int reverse_array_count = 0;
            for (int i=length-1; i >= 0; i--) {
                reverse_array[reverse_array_count++] = numbers[i];
            }
            numbers = reverse_array;
        }
        
        public void insertAt(int index, int item) {
            if (index < 0 || index >= length)
                throw new ArgumentException();

            numbers[index] = item;


        }
    }
}