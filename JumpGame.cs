public class Solution {
    public bool CanJump(int[] nums) 
    {
        int finishIndex = nums.Length - 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (i + nums[i] >= finishIndex)
            {
                if (i == 0) return true;
                finishIndex = i;
            }
        }
        return false;
    }
}