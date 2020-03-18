using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
namespace DataStructuresAlgo.binarytree
{
    public class TreeCustom
    {

        private Node root = null;

        public bool find(int value) {
            var current = root;
            while (current!=null) {
                if (value < current.value) {
                    current = current.leftChild;
                }
                else if (value > current.value) {
                    current = current.rightChild;
                    continue;
                }
                else {
                    return true;
                }
            }
            return false;
        }


        public void insert(int item) {
            if(this.root == null) {
                this.root = new Node(item);    
                return;           
            }
            var current = root;
            while(current != null) {
            if(item < current.value) {
                if(current.leftChild == null) {
                    current.leftChild = new Node(item);
                }
                else {
                    current = current.leftChild;
                    continue;
                }
            }
            if (item > current.value) {
                if(current.rightChild == null) {
                    current.rightChild = new Node(item);
                }
                else {
                    current = current.rightChild;
                    continue;
                }
            }
            break;
            }
       }
    

        public void Traversal() {
            postorderTraversal(root);
        }
        private void preorderTraversal(Node root) {
            if (root == null) return;
            System.Console.WriteLine(root.value);
            preorderTraversal(root.leftChild);
            preorderTraversal(root.rightChild);
        }

        private void inorderTraversal(Node root) {
            if(root==null) return;
            inorderTraversal(root.leftChild);
            System.Console.WriteLine(root.value);
            inorderTraversal(root.rightChild);

        }

        private void postorderTraversal(Node root){
            if(root==null) return;
            postorderTraversal(root.leftChild);
            postorderTraversal(root.rightChild);
            System.Console.WriteLine(root.value);
        }

        public int height() {
            return height(root);
        }
        
        private bool isLeaf(Node node) {
            return root.leftChild == null && root.rightChild == null;
           
        }

        private int height(Node root) {
            if(isLeaf(root) || root == null)
                return 0;
            return 1 + Math.Max(height(root.leftChild),height(root.rightChild));
        }

        public int min() {
            if (root == null) {
                throw new InvalidOperationException();
            }
            var current = root;
            var last = current;
            while(current != null) {
                last = current;
                current = current.leftChild;
            }
            return last.value;
        }

        private int min(Node root) {
            if(isLeaf(root))
                return root.value;
            var left = min(root.leftChild);
            var right = min(root.rightChild);
            return Math.Min(Math.Min(left,right), root.value);
        }

        public bool Equals(TreeCustom tree) {
            if(tree == null) return false;
            return EqualsNode(root, tree.root);
        }

        private bool EqualsNode(Node first, Node second) {
            if(first == null && second == null) {
                return true;
            }
            if(first != null && second != null) {
                 return first.value == second.value &&  EqualsNode(first.leftChild, second.leftChild) && EqualsNode(first.rightChild, second.rightChild);
            }
            return false;
            
        }

        public bool ValidateBinary() {
            return ValidateBinarySerach(root,min: int.MinValue, max: int.MaxValue);
        }

        private bool ValidateBinarySerach(Node node, int min, int max) {
            if (node == null) {
                return true;
            }
            if(node.value < min || node.value > max)
                return false;
            return ValidateBinarySerach(node.leftChild, min, max: node.value - 1) && ValidateBinarySerach(node.rightChild, min: node.value+1, max);
        }

        public List<int> KDistanceNode(int distance) {
            var array = new List<int>();
            KDistanceNode(root, distance, ref array);
            return array;
        }

        private void KDistanceNode(Node node, int distance, ref List<int> list) {
            if (node == null) {
                return;
            }
            if(distance == 0) {
                // System.Console.WriteLine("Root node of the distance is: {0}",node.value);
                list.Add(node.value);
            }
            KDistanceNode(node.leftChild, distance - 1, ref list);
            KDistanceNode(node.rightChild, distance - 1, ref list);
        }


        public void PrintLevelTraversal()  {
            PrintLevelTraversal(root);
        }

        private void PrintLevelTraversal(Node node) {
            for(int i=0; i<=height();i++) {
                foreach(var item in KDistanceNode(i)) {
                    System.Console.WriteLine(item);
                }
            }
        }
    }
        
}