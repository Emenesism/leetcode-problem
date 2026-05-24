public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int first = FindFirst(nums, target);
        int last = FindLast(nums, target);

        return new int[] { first, last };
    }
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return new[] { -1, -1 };
            }
            if (nums.Length == 1 && nums[0] == target)
            {
                return new[] { 0, 0 };
            }
            List<int> result = new();
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    result.Add(mid);
                }

                if (nums[mid] > target)
                {
                    right = mid - 1;
                }



            }
            Array.Sort(result);
            return result;
        }
    }

    private int FindFirst(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        int answer = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                answer = mid;
                right = mid - 1;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return answer;
    }

    private int FindLast(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        int answer = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                answer = mid;
                left = mid + 1;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return answer;
    }
}
