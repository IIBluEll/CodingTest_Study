// [문제 링크]: https://www.acmicpc.net/problem/14916

class _14916
{
    private static void Main(string[] strings)
    {
        var n = Int32.Parse(Console.ReadLine());
        
        Console.WriteLine(Solution(n));
    }
​
    private static int Solution(int n)
    {
        var minV = int.MaxValue;
​
        for (var i = 0; i <= n / 5; i++)
        {
            var tempV = n - (i * 5);
​
            if (tempV % 2 == 0)
            {
                var minCoin = i + (tempV / 2);
                minV = Math.Min(minV, minCoin);
            }
        }
​
        return minV == int.MaxValue ? -1 : minV;
    }
}