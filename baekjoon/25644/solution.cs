// [문제 링크]: https://www.acmicpc.net/problem/25644

class _25644
{
    private static void Main(string[] strings)
    {
       var N = Int32.Parse(Console.ReadLine());
        var a = new int[N];
        var temp = Console.ReadLine().Split(' ');        
        for (var i = 0; i < N; i++)
        {
            a[i] = Int32.Parse(temp[i]);
        }
        Console.WriteLine(Solution(a));
    }
    private static int Solution(int[] sol)
    {
        var maxV = 0;
        var minV = sol[0];
        for (var i = 1; i < sol.Length; i++)
        {
            maxV = Math.Max(maxV, sol[i] - minV);
            minV = Math.Min(minV, sol[i]);
        }
        return maxV;
    }
}