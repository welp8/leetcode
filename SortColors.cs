public class Solution { //dutch national flag algoritm
    public void SortColors(int[] nums) {
        int low =0;
        int mid =0;
        int high = nums.Length-1;
        int temp = 0;

        while (mid<=high){

            if (nums[mid]==0){
                temp=nums[low];
                nums[low]=nums[mid];
                nums[mid]=temp;
                low++;
                mid++;

            }else if(nums[mid]==1){
                mid++;

            }else if(nums[mid]==2){
                temp=nums[high];
                nums[high]=nums[mid];
                nums[mid]=temp;
                high--;
            }
        }
    }
}