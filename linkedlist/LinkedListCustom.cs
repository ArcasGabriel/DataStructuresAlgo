using System;
namespace DataStructuresAlgo.linkedlist
{
    public class LinkedListCustom
    {
        private NodeCustom first;
        private NodeCustom last;
        private int el_size = 0;

        public bool IsEmpty() {
            return first == null;
        }

        public void addFirst(int value) {
            var new_node = new NodeCustom(value:value);
            if (first == null) {
                first = last = new_node;
            }
            else {
                new_node.SetNode(first);
                first = new_node;
            }
            el_size++;
        }

        public void addLast(int value) {
            var new_node = new NodeCustom(value:value);
            if (first == null)
              last = first = new_node;
            else {
            last.SetNode(new_node);
            last = new_node;
            }
            el_size++;
        }

        public void deleteFirst() {
           if (IsEmpty())
            throw new IndexOutOfRangeException();
           if (first != null && first.GetNext() != null) {
            var new_first = first.GetNext();
            first.SetNode(null);
            first = new_first;
           }
           else {
               first = last = null;
           }
           el_size--;
        }

        public void deleteLast() {
           if (IsEmpty())
            throw new IndexOutOfRangeException();
            if (first != null) {
                var current = first;
                NodeCustom new_last = null;
                while(new_last == null) {
                    if (current.GetNext() == last) {
                        new_last = current;
                        current.SetNode(null);
                        new_last.SetNode(null);
                        last = new_last;
                    }
                    current = current.GetNext();
                }
            }
            else {
                first = last = null;
            }
            el_size--;
        }

        public bool contains(int item) {
            return indexOf(item) != -1;
        }
        
        public int indexOf(int item) {
            int index = 0;
            var current = first;
            while(current != null){
                if(current.GetValue() == item) {
                    return index;
                }
                current = current.GetNext();
                index++;
            }
            return -1;
        }

        public int size() {
            return el_size;
        }


        public int[] toArray() {

           if (IsEmpty())
            throw new IndexOutOfRangeException();
            var new_array = new int[el_size];
            var index=0;
            var current=first;
            while(current != null) {
                new_array[index++] = current.GetValue();
                current = current.GetNext();
            }

            return new_array;


        }

        public void reverse() {
            // [10 <- 20 <- 30]
            //  p     c  n
            //  n = c.next
            //  p = c.next
            var previous = first;
            var current = first.GetNext();
            while(current!=null){
                var next = current.GetNext();
                current.SetNode(previous);
                previous = current;
                current = next;
            }
            last = first;
            last.SetNode(null);
            first = previous;
         }

        public int getKthNodeToEnd(int k) {
            if (IsEmpty()) 
                throw new ArgumentException();
            var first_node = first;
            var second_node = first;
            for (int i=0; i<k-1; i++) {
                second_node = second_node.GetNext();
            }
            while(second_node != last) {
                first_node = first_node.GetNext();
                second_node = second_node.GetNext();
            }
            return first_node.GetValue();
        }
        
    }
}