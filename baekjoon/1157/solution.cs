// [문제 링크]: https://www.acmicpc.net/problem/1157

namespace BaekJoon
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string temp = Console.ReadLine().ToUpper();
​
            char[] alaphChars = temp.ToCharArray();
​
            var alaphDic = new Dictionary<char, int>();
​
            foreach (var c in alaphChars)
            {
                if (alaphDic.ContainsKey(c))
                {
                    alaphDic[c]++;
                }
                else
                {
                    alaphDic[c] = 1;
                }
            }
​
            int maxValue = alaphDic.Values.Max();
            char maxKey = alaphDic.FirstOrDefault(x => x.Value == maxValue).Key;
​
            bool isMultiple = alaphDic.Count(k => k.Value == maxValue) > 1;
​
            if (isMultiple)
            {
                Console.WriteLine("?");
            }
            else
            {
                Console.WriteLine(maxKey);
            }
        }
    }
}
​
​