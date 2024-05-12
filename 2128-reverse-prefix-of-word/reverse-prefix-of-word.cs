public class Solution {
    public string ReversePrefix(string word, char ch) {
        var stringBuilder = new StringBuilder();
        var prepend = true;

        foreach(var c in word){
            if (prepend){
                stringBuilder.Insert(0, c);
            } else {
                stringBuilder.Append(c);
            }

            if (c == ch){
                prepend = false;
            }
        }

        // never found
        if (prepend){
            return word;
        }


        return stringBuilder.ToString();
    }
}