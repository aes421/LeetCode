public class Solution {
    public int[][] LargestLocal(int[][] grid) {
        var result = new int[grid.Length-2][];
        for (int i = 0; i < result.Length; i++){
            result[i] = new int[grid.Length-2];
        }

        for (int iResult = 0; iResult < result.Length; iResult++){
            for (int jResult = 0; jResult < result[0].Length; jResult++){
                for (int iGrid = iResult; iGrid < iResult+3; iGrid++){
                    for (int jGrid = jResult; jGrid < jResult+3; jGrid++){
                        result[iResult][jResult] = Math.Max(result[iResult][jResult], grid[iGrid][jGrid]);
                    }
                }
            }
        }

        return result;
    }
}