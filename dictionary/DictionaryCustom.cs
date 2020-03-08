using System;
using System.Collections;
using System.Collections.Generic;
namespace DataStructuresAlgo.dictionary
{
    public class DictionaryCustom
    {
        
        private LinkedList<KeyValuePairCustom>[] slots = new LinkedList<KeyValuePairCustom>[6];

        public int hash(int number) {
            return number % slots.Length;
        }

        public void Put(int key, string value) {
            var index = hash(key);
            if(slots[index] == null) {
                slots[index] = new LinkedList<KeyValuePairCustom>();
            }
            var bucket = slots[index];
            foreach(var item in bucket) {
                if(item.GetKey() == key){
                    item.SetValue(value);
                    return;
                }
            }
            bucket.AddLast(new KeyValuePairCustom(key,value));
        }

        public string Get(int key) {
            var index = hash(key);
            var ll = slots[index];
            foreach(var item in ll){
                if(item.GetKey() == key) {
                    return item.GetValue();
                }
            }
            return "";
        }


        public void Remove(int key) {
            var index = hash(key);
            var ll = slots[index];
            if(ll != null) {
            foreach(var item in ll) {
                if(item.GetKey() == key) {
                    ll.Remove(item);
                    return;
                }
            }
            }
        }

    }
}