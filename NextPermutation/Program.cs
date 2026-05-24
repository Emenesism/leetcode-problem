public class Solution
{
    public void NextPermutation(int[] nums)
    {
        for (int i = nums.Length - 1; i > 0; i--)
        {
            if (nums[i] > nums[i - 1])
            {
                int pivot = i - 1;

                for (int j = nums.Length - 1; j > pivot; j--)
                {
                    if (nums[j] > nums[pivot])
                    {
                        (nums[pivot], nums[j]) = (nums[j], nums[pivot]);
                        Array.Reverse(nums, pivot + 1, nums.Length - (pivot + 1));
                        return;
                    }
                }
            }
        }

        Array.Reverse(nums);
    }
}
