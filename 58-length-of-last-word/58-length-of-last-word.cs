public class Solution {
    public int LengthOfLastWord(string s) {
        
        string revString = Reverse(s);

        Stack st = new Stack();
        foreach(char c in revString.ToCharArray()){
            if(c != ' ') {st.Push(c);}
            else if(c == ' ' && st.Count > 0) {return st.Count;}
        }
        return st.Count;
    }
    
    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}