public class Solution {
    public bool IsPalindrome(int x) {
        int root = x;
        if (x < 0) {
            return false;
        }
        else {
            int k = 0;
            while (x > 0) {
                k = (x % 10) + k * 10;
                x /= 10;
            }
            if (k == root) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
