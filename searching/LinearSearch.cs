namespace DataStructuresAlgo.searching
{
    public class LinearSearch
    {
        private int[] numbers;

        public LinearSearch(int[] numbers)
        {
            this.numbers = numbers;
            
        }

        public int Searching(int target) {
            if (numbers.Length == 0 ) {
                return -1;
            }
            for(int i=0; i<numbers.Length; i++) {
                if(target==numbers[i]) {
                    return i;
                }
            }
            return -1;
        }
        
    }
}