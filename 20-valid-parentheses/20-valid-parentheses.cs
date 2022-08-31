public class Solution {
    public bool IsValid(string s) {
        
        Stack stack = new Stack();
        foreach(char c in s.ToCharArray()){
            if(c=='(' || c=='{' || c=='[') { stack.Push(c); }
            else if(c==')' && stack.Count !=0 && (char) stack.Peek() == '(') {stack.Pop();}
            else if(c=='}' && stack.Count !=0 && (char) stack.Peek() == '{') {stack.Pop();}
            else if(c==']' && stack.Count !=0 && (char) stack.Peek() == '[') {stack.Pop();}
            else { return false; }
        }
        if(stack.Count >= 1) { return false; }
        return true;
        
       //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
       // int n = -1;
       //  while (s.Length != n) {
       //      n = s.Length;
       //      s = s.Replace("()", "");
       //      s = s.Replace("{}", "");
       //      s = s.Replace("[]", "");
       //  }
       //  return (s.Length == 0)? true : false;
    }
}