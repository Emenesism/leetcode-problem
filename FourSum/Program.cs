public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();
        var length = nums.Length;
        for (int i = 0; i < length - 3; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            if ((long)nums[i] + nums[i + 1] + nums[i + 2] + nums[i + 3] > target) continue;
            if ((long)nums[i] + nums[length - 1] + nums[length - 2] + nums[length - 3] < target) continue;

            for (int j = i + 1; j < length - 2; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1]) continue;


                var left = j + 1;
                var right = length - 1;

                while (left < right)
                {
                    long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];
                    if (sum == target)
                    {
                        result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                        left++;
                        right--;
                        while (left < right && nums[left] == nums[left - 1]) left++;
                        while (left < right && nums[right] == nums[right + 1]) right--;
                        continue;
                    }
                    if (sum > target)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }

            }
        }
        return result;
    }
}
