public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var slow = 0;
        var fast = 0;
        while (fast < nums.Length)
        {
            if (nums[fast] != val)
            {
                nums[slow] = nums[fast];
                slow++;
            }
            fast++;
        }
        return slow;
    }
}
