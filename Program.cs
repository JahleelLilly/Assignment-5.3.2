namespace Assignment_5._3._2
{
    public class Staircase
    {
        public int ClimbStairs(int n)
        {
            if (n <= 2)
            {
                return n;
            }

            //dp[i] represents the number of ways to climb i steps

            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }
    }
}