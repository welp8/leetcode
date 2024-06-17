class Solution {
public:
    int minimumTotal(vector<vector<int>>& triangle) {
        int n = triangle.size();
        if (n == 1) {
            return triangle[0][0];
        } else {

            //for triangle example [[1], [5, 3], [3, 9, 3]]
            //vector of last row of triangle = [3, 9, 3]
            vector<int> dp(triangle[n - 1]);
            
            // Iterate from the second last row to the top
            for (int i = n - 2; i >= 0; --i) {
                for (int j = 0; j <= i; ++j) {
                    // Update dp[j] to be the minimum path sum of the current element
                    dp[j] = triangle[i][j] + min(dp[j], dp[j + 1]); //for 5, 5+3 is the min so 8 stored in dp[0] for 3, 3+3 is the min so 6 is stored in dp[1]
                }
            }
            
            // The first element of dp will contain the minimum path sum
            return dp[0];
        }
    }
};
