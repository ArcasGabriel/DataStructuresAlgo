namespace DataStructuresAlgo.priorityqueue
{
    public class PriorityQueue
    {
        private int[] numbers = new int[5];
        private int count = 0;       

        public void insert(int item) {
            
            int i=0;
            if(count + 1 > numbers.Length) {
                var new_array = new int[count * 2];
                for(i=0;i<count;i++) {
                    new_array[i] = numbers[i];
                }
                numbers = new_array;
            }
                for(i=count-1; i >= 0; i--) {
                    if (numbers[i] > item) {
                        // [1,3,5]  2 
                        // [1,3,5,5,7]
                        numbers[i+1] = numbers[i];
                    }
                    else {
                        break;
                    }
                }
            numbers[i+1] = item;
            count++;
        }

        public int remove() {
            return numbers[count--];
        }
    }
}