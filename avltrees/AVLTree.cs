using System;
namespace DataStructuresAlgo.avltrees
{
    public class AVLTree
    {

        private AVLNode root;

        public void insert(int value) {
            root = insert_node(root, value);
        }

        private bool isLeaf(AVLNode root) {
            return root.leftChild == null && root.rightChild == null;
        }

        private AVLNode insert_node(AVLNode node, int value) {
            if(node == null) {
                return new AVLNode(value);
            }
            if(value < node.value) 
                node.leftChild = insert_node(node.leftChild, value);
            else {
                node.rightChild = insert_node(node.rightChild, value);
            }
            node.height = 1 + Math.Max(height(node.leftChild), height(node.rightChild));

            if(isLeftHeavy(node)) {
                // left heavy -> right rotation
                if(balanceFactor(node.leftChild) < 0) {
                    System.Console.WriteLine("Left rotation on: {0}", node.leftChild.value);
                }
                System.Console.WriteLine("Right rotation on: {0}",node.value);
            }
            else if(isRightHeavy(node)) {
                if(balanceFactor(node.rightChild) > 0) {
                    System.Console.WriteLine("Right rotation on: {0}", node.rightChild.value);
                }
                System.Console.WriteLine("Left rotation on: {0}",node.value);
            }

            return node;

        }

        private int balanceFactor(AVLNode node){
            return (root == null)? 0: height(node.leftChild) - height(node.rightChild);
        }

        private bool isLeftHeavy(AVLNode node) {
            return balanceFactor(node) > 1;
        }

        private bool isRightHeavy(AVLNode node) {
            return balanceFactor(node) < -1;
        }

        private int height(AVLNode node) {
            return (node == null)? -1:node.height;
        }
        
    }
}