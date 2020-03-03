using System.Collections;
using System;
using System.Data;
using System.Collections.Generic;
namespace DataStructuresAlgo.balancedexpressions
{
    public class BalancedExpressions
    {
        
        List<char> right_bracket = new List<char>(){')',']','}'};
        List<char> left_bracket = new List<char>(){'(','[','{'};
        public bool syntax_ok(string input) {

            Stack<char> local_stack = new Stack<char>();
            foreach (var character in input) {
                if(is_left_bracket(character)) {
                    local_stack.Push(character);
                }
                if (is_right_bracket(character)) {
                    if(local_stack.Count == 0) return false;

                    var top = local_stack.Pop();
                    if(!brackets_match(top,character)) return false;
                }
            }  

            return local_stack.Count==0;


        }

        public bool is_left_bracket(char bracket) {
            return left_bracket.Contains(bracket);
        }

        public bool is_right_bracket(char bracket) {
            return right_bracket.Contains(bracket);
        }

        public bool brackets_match(char left, char right) {
            return left_bracket.IndexOf(left) == right_bracket.IndexOf(right); 
        }
    }
}