public class Solution {
    public int Fib(int n) {
        List<int> fibList = new List<int>();
        fibList.Add(0);
        fibList.Add(1);
        if (n == 0 || n == 1) {
            return n;
        }
        for (int i = 2; i <= n; i++) {
            int newResult = fibList[i - 1] + fibList[i - 2];
            fibList.Add(newResult);
        }
        return fibList[^1];
    }
}
