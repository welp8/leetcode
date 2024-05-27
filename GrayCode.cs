public class Solution {
    public IList<int> GrayCode(int n)
    {
        IList<int> result = new List<int>();
        int totalNumbers = 1 << n; 
        
        for (int i = 0; i < totalNumbers; i++)
        {
            result.Add(i ^ (i >> 1));
        }

        return result;
    }
}