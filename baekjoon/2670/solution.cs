// [문제 링크]: https://www.acmicpc.net/problem/2670

var count = Int32.Parse(Console.ReadLine());
​
var numbers = new double[count];
​
for (var i = 0; i < count; i++)
{
    numbers[i] = Double.Parse(Console.ReadLine());
}
​
var maxV = double.MinValue;
double nowV = 1f;
​
for (var i = 0; i < count; i++)
{
    nowV = Math.Max(nowV * numbers[i], numbers[i]);
    maxV = Math.Max(maxV, nowV);
}
​
Console.WriteLine(maxV.ToString("F3"));