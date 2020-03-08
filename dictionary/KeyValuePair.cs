namespace DataStructuresAlgo.dictionary
{
    public class KeyValuePairCustom
    {
        private int key;
        private string value;

        public KeyValuePairCustom(int key, string value)
        {
            this.key = key;
            this.value = value;
        }

        public void SetKey(int key) {
            this.key = key;
        }

        public int GetKey() {
            return this.key;
        }

        public void SetValue(string value) {
            this.value = value;
        }

        public string GetValue() {
            return this.value;
        }
    }
}