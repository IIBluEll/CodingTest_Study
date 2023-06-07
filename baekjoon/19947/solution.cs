// [문제 링크]: https://www.acmicpc.net/problem/19947

var temp = Console.ReadLine().Split(' ');
​
var h = Int32.Parse(temp[0]);
var y = Int32.Parse(temp[1]);
​
var dpA = new int[y + 1];
dpA[0] = h;
​
int maxB = 0, maxC = 0;
​
for (var i = 1; i <= y; i++)
{
    var a = (int)(dpA[i - 1] * 1.05);
​
    if (i >= 3)
    {
        maxB = (int)Math.Max(maxB, dpA[i - 3] * 1.2);
        if (i >= 5)
        {
            maxC = (int)Math.Max(maxC, dpA[i - 5] * 1.35);
        }
    }
​
    dpA[i] = Math.Max(a, Math.Max(maxB, maxC));
}
​
Console.WriteLine(dpA[y]);