// [문제 링크]: https://www.acmicpc.net/problem/9656

class _9656
{
    private static void Main(string[] strings)
    {
        var n = Int32.Parse(Console.ReadLine()); 
        Console.WriteLine(Solution(n));
    }
    private static string Solution(int n)
    {
        string temp = n % 2 == 0 ? "SK" : "CY";
        return temp;
    }
}