namespace DataStructuresAlgo.sorting
{
    public class InsertionSort
    {
        public int[] sort(int[] numbers) {

            for(int i=0;i<numbers.Length;i++) {

                var current = numbers[i];
                var j = i-1;
                while(j>=0 && numbers[j] > current) {
                    numbers[j+1] = numbers[j];
                    j--;
                }
                numbers[j+1] = current;

            }


            return numbers;
        }   

    }
}