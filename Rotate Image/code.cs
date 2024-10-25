  public class Solution {
    public void Rotate(int[][] matrix) {
        if (matrix.Length == 1) {
            Console.WriteLine("+");
        }
        else if (matrix.Length == 2) {
            int temp = matrix[0][1];
            matrix[0][1] = matrix[1][0];
            matrix[1][0] = temp;
        }
        else {
            for (int i = 0; i < matrix.Length; i++) {
                for (int j = i; j < matrix[i].Length; j++) {
                    if (i != j && j - i > 0) {
                        int temp_0 = matrix[i][j];
                        matrix[i][j] = matrix[j][i];
                        matrix[j][i] = temp_0;
                    }

                }
            }
        }
        foreach (int[] arr in matrix) {
            Array.Reverse(arr);
        }
    }
}
