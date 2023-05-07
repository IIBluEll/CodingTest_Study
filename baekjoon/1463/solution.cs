// [문제 링크]: https://www.acmicpc.net/problem/1463

class _1463
{
    private static void Main(string[] strings)
    {
        int x = Int32.Parse(Console.ReadLine());
​
        Console.WriteLine(Solution(x));
    }
​
    private static int Solution(int x)
    {
        var dp = new int[x + 1];
        dp[1] = 0; // => 1은 계산이 필요없으니 0
​
        for (var i = 2; i <= x; i++)
        {
            dp[i] = dp[i - 1] + 1;  //=> 1를 빼는 연산은 언제든 가능함으로 기본으로 둠 
​
            if (i % 2 == 0)
            {
                dp[i] = Math.Min(dp[i], dp[i / 2] + 1);
            }
​
            if (i % 3 == 0)
            {
                dp[i] = Math.Min(dp[i], dp[i / 3] + 1);
            }
        }
​
        return dp[x];
    }
}