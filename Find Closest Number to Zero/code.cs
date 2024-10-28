public class Solution {
    public int FindClosestNumber(int[] nums) {
            int temp;
            Array.Sort(nums);
            Array.Reverse(nums);
            int result = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] >= 0 && nums[i + 1] <= 0)
                {
                    if (nums[i] <= nums[i + 1] * (-1)) {
                        result = nums[i];
                    }
                    else {
                        result = nums[i + 1];
                    }
                }
                else if (nums[0] < 0) {
                    result = nums[0];
                }
                else if (nums[nums.Length-1] > 0) {
                    result = nums[nums.Length-1];
                }
            }
            return result;
    }
}
