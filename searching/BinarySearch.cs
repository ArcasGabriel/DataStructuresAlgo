namespace DataStructuresAlgo.searching
{
    public class BinarySearch
    {
        public BinarySearch()
        {
            
        }
        public int Search(int number, int[] numbers) {
            return SearchEc(number, numbers, 0, numbers.Length-1);
        }

        public int SearchEc(int number, int[] numbers, int left, int right) {
            if(right < left) {
                return -1;
            }
            var middle = (left + right) / 2;
        
            if(numbers[middle] == number) {
                return middle;
            }
            if(number < numbers[middle]) {
                return SearchEc(number, numbers, left, right: middle-1);
            }
            if(number > numbers[middle]) {
                return SearchEc(number,numbers,left: middle+1, right);
            }
            return -1;
        }

    }
}