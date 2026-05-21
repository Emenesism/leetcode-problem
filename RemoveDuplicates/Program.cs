public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var slow = 0;
        var fast = 1;
        while (fast < nums.Length)
        {
            if (nums[slow] != nums[fast])
            {
                slow++;
                nums[slow] = nums[fast];
            }
            else
            {
                fast++;
            }
        }
        return slow + 1;
    }
}
