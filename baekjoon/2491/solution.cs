// [문제 링크]: https://www.acmicpc.net/problem/2491

var n = Int32.Parse(Console.ReadLine());
var tempnums = Console.ReadLine().Split(' ');
var nums = Array.ConvertAll(tempnums, int.Parse);
​
var maxCounts = 1;
var nowCounts = 1;
var nowDownCounts = 1;
var nowUpCounts = 1;
​
for (var i = 1; i < n; i++)
{
    if (nums[i] > nums[i - 1])
    {
        nowCounts = nowUpCounts + 1;
        nowUpCounts++;
        nowDownCounts = 1;
    }
    else if (nums[i] < nums[i - 1])
    {
        nowCounts = nowDownCounts + 1;
        nowDownCounts++;
        nowUpCounts = 1;
    }
    else
    {
        nowCounts++;
        nowDownCounts++;
        nowUpCounts++;
    }
​
    maxCounts = Math.Max(maxCounts, nowCounts);
}
​
Console.WriteLine(maxCounts);