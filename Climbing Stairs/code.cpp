public class Solution {
    public int ClimbStairs(int n) {
        int count = 0;
        List<int> hobbanoci = new List<int>();
        hobbanoci.Add(2);
        hobbanoci.Add(3);
        if (n > 2) {
            for (int i = 1; i < n - 2; i++) {
                hobbanoci.Add(hobbanoci[i] + hobbanoci[i - 1]);
                count ++;
            }
            return hobbanoci[^1];
        }
        else {
            return n;
        }


    }
}
