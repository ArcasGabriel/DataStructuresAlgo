namespace DataStructuresAlgo.sorting
{
    public class SelectionSort
    {
        public int[] sort(int[] numbers) {

            for(int i=0; i<numbers.Length;i++)  {
                var minIndex = i;
                for(int j=i; j<numbers.Length;j++) {
                    if(numbers[j] < numbers[minIndex]) {
                        minIndex = j;
                    }
                }
                    int temp = numbers[i];
                    numbers[i] = numbers[minIndex];
                    numbers[minIndex] = temp;
            }
            return numbers;
        }
    }
}