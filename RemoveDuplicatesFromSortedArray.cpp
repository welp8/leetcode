class Solution {
public:
    int removeDuplicates(vector<int>& nums) {

        if (nums.empty()) return 0;
        int counter = 1;
        for (int i = 1; i < nums.size(); ++i) {
            if (nums[i] != nums[i - 1]) {
                nums[counter] = nums[i];
                ++counter;
            }
        }
        nums.resize(counter);
        return counter;
    }
};