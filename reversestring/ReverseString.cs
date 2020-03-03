using System.Collections.Generic;
using System.Text;
namespace DataStructuresAlgo.reversestring
{
    public class ReverseString
    {
        public string revers(string input) {
            Stack<string> stack_local = new Stack<string>();

            foreach(var character in input) {
                stack_local.Push(character.ToString());
            }
            StringBuilder stringBuilder = new StringBuilder();
            while(!(stack_local.Count == 0)){
                stringBuilder.Append(stack_local.Pop());
            }
            return stringBuilder.ToString();
        }
    }
}