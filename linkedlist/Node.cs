namespace DataStructuresAlgo.linkedlist
{
    public class NodeCustom
    {
        private int value;
        private NodeCustom next;

        public void SetNode(NodeCustom next) {
            this.next = next;
        }

        public NodeCustom GetNext(){
            return this.next;
        }

        
        public int GetValue(){
            return this.value;
        }

        public NodeCustom(int value)
        {
            this.value = value;
        }
        
    }
}