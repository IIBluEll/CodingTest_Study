// [문제 링크]: https://www.acmicpc.net/problem/1152

namespace BaekJoon
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split(' ');
            
            if (temp[0] == "" && temp[temp.Length - 1] == "")
            {
                Console.WriteLine(temp.Length - 2);
            }
            else if (temp[0] == "" || temp[temp.Length - 1] == "")
            {
                Console.WriteLine(temp.Length - 1);
            }
            else
            {
                Console.WriteLine(temp.Length);
            }
        }
    }
}