public class Solution
{
    public int MaxArea(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var max = 0;
        while (left < right)
        {
            var tempMaxArea = Math.Min(height[left], height[right]) * (right - left);
            if (tempMaxArea > max)
            {
                max = tempMaxArea;
            }
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return max;
    }
}
