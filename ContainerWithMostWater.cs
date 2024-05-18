/* public class Solution {
    public int MaxArea(int[] height) {
        int max=0;
        for (int i=0; i<height.Length-1; i++){
            for(int j=1; j<=height.Length-1; j++){

                int gap = j-i;
                int ans=0;
                if (height[i]>height[j]){
                    ans=height[j]*gap;

                }else if (height[i]<height[j]){
                    ans=height[i]*gap;
                }else{
                    ans=height[i]*gap;
                }

                if(max<ans){
                max=ans;
                }
            }
            
        }

        return max;
    }
}
*/

public class Solution
{
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int max = 0;
        int gap = 0;
        int ans = 0;
        while (left < right)
        {
            gap = right - left;
            if (height[right] > height[left])
            {
                ans = height[left] * gap;
            }
            else if (height[right] < height[left])
            {
                ans = height[right] * gap;
            }
            else
            {
                ans = height[right] * gap;
            }
            if (height[left] > height[right])
            {
                right--;
            }
            else if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                left++;
            }
            if (max < ans)
            {
                max = ans;
            }
        }
        return max;
    }
}