// [문제 링크]: https://www.acmicpc.net/problem/1008

namespace BaekJoon
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split(' '); 
            
            double valueA = double.Parse(temp[0]);
            double valueB = double.Parse(temp[1]);
​
            double result = valueA / valueB;
            
            Console.WriteLine(result);
        }
    }
}
​
​