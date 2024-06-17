class Solution {
public:
    double myPow(double x, int n) {
        // Handle the edge case where x is 0
        if (x == 0) return 0;

        // Handle the edge case where n is 0
        if (n == 0) return 1;

        // Handle the case where n is negative
        long long absN = n; // Use long long to handle INT_MIN correctly
        if (n < 0) {
            absN = -absN;
            x = 1 / x;
        }

        double result = 1.0;
        double currentProduct = x;

        while (absN > 0) {
            if (absN % 2 == 1) {
                result *= currentProduct;
            }
            currentProduct *= currentProduct;
            absN /= 2;
        }

        return result;
    }
};
