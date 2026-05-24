public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            while (1 <= nums[i] && nums[i] <= nums.Length && nums[nums[i] - 1] != nums[i])
            {
                (nums[i], nums[nums[i] - 1]) = (nums[nums[i] - 1], nums[i]);
            }
        }

        for (int j = 0; j < nums.Length; j++)
        {
            if (nums[j] != j + 1)
            {
                return j + 1;
            }
        }

        return nums.Length + 1;
    }
}
