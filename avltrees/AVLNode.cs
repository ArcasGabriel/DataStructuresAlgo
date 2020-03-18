namespace DataStructuresAlgo.avltrees
{
    public class AVLNode
    {
        public int value;
        public AVLNode leftChild;
        
        public AVLNode rightChild;

        public int height;

        public AVLNode(int value)
        {
            this.value = value;
        }
        
    }
}