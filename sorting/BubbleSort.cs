namespace DataStructuresAlgo.sorting
{
    public class BubbleSort
    {

        public int[] sort(int[] numbers) {
           bool isSorted;
           for(int i=0;i<numbers.Length;i++) {
               isSorted = true;
               for(int j=1; j<numbers.Length-i;j++) {
                   if(numbers[j] < numbers[j-1]) {
                       int temp = numbers[j];
                       numbers[j] = numbers[j-1];
                       numbers[j-1] = temp;
                       isSorted = false;
                   }
               }
               if(isSorted) return numbers;
           }
           return numbers;
        }
    }
}