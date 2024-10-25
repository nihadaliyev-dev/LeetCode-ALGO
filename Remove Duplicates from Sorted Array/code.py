class Solution:
    def removeDuplicates(self, nums: List[int]) -> int: #[1,1,1,1]
        j = 1
        for i in range(1, len(nums)):  #1,2
            if nums[i] != nums[i - 1]:
                nums[j] = nums[i]
                j += 1
                print(j)
        return j
