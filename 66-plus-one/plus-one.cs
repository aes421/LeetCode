public class Solution {
    public int[] PlusOne(int[] digits) {
        var digitsList = new List<int>();
        var adding = 1;
        var i = digits.Length-1;
        Console.WriteLine(i);

        while (i >= 0){
            var result = digits[i]+adding;
            if (result == 10){
                digitsList.Add(0);
                adding = 1;
            }
            else{
                digitsList.Add(result);
                adding = 0;
            }
            i--;
        }
        if (adding == 1){
            digitsList.Add(1);
        }

        digitsList.Reverse();
        return digitsList.ToArray();
    }
}

// [1,2,4]