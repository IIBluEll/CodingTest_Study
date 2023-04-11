// [문제 링크]: https://www.acmicpc.net/problem/1769

class Q1769
{
    static int check = 0;
​
    static void Main(string[] strings)
    {
        string x = Console.ReadLine();
​
        char[] xs = x.ToCharArray();
        int[] ints = new int[xs.Length];
​
        for (int i = 0; i < xs.Length; i++)
        {
            ints[i] = Int32.Parse(xs[i].ToString());
        }  
​
        string is3 = CheckNum(ints) % 3 == 0 ? "YES" : "NO";
​
        Console.WriteLine($"{check}");
        Console.WriteLine(is3);
    }
​
    // 정수를 문자 배열로 바꿈
    static int[] CharToInt(int ints)
    {
        string temp = ints.ToString();
        char[] tempchar = temp.ToCharArray();
        int[] tempints = new int[tempchar.Length];
​
        for (int i = 0; i < tempchar.Length; i++)
        {
            tempints[i] = Int32.Parse(tempchar[i].ToString());
        }
​
        return tempints;
    }
    
    // 숫자 각 자리를 더해서 10 미만인지 체크
    static int CheckNum(int[] ints)
    {
        if (ints.Length == 1)
            return ints[0];
​
        int sum = 0;
        check++;
        foreach (int i in ints)
        {
            sum += i;    
        }
​
        if (sum < 10)
            return sum;
        else
        {
            CheckNum(CharToInt(sum));
        }   
        return sum;
    }
}