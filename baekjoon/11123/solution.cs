// [문제 링크]: https://www.acmicpc.net/problem/11123

class _1326
{
    private static int solution = 0;
    
    private static void Main(string[] strings)
    {
        var t = Int32.Parse(Console.ReadLine());
        var sol = new int[t];
        for (var i = 0; i < t; i++)
        {
            solution = 0;
            
            var tempS = Console.ReadLine().Split(' ');
            var h = Int32.Parse(tempS[0]);
            var w = Int32.Parse(tempS[1]);
​
            var maps = InputMap(h, w);
​
            for (var a = 0; a < h; a++)
            {
                for (var b = 0; b < w; b++)
                {
                    if (maps[a, b] == '#')
                    {
                        DFS(a, b, maps, h, w);
                        solution++;
                    }
                }
            }
            Console.WriteLine(solution);
        }
    }
​
    private static char[,] InputMap(int h, int w)
    {
        var tempM = new string[h];
        var map = new char[h,w];
        
        for (var i = 0; i < h; i++)
        {
            tempM[i] = Console.ReadLine();
            for (var j = 0; j < w; j++)
            {
                map[i, j] = tempM[i][j];
            }
        }
​
        return map;
    }
​
    private static void DFS(int y, int x, char[,] maps, int h, int w)
    {
        if (maps[y, x] == '#')
        {
            maps[y, x] = '.';
            var goY = new int[] { -1, 1, 0, 0 };
            var goX = new int[] { 0, 0, 1, -1 };
​
            for (var i = 0; i < 4; i++)
            {
                int nextY = y + goY[i];
                int nextX = x + goX[i];
​
                if (IsCanGo(nextY, nextX, h, w) && maps[nextY, nextX] == '#')
                {
                    DFS(nextY, nextX, maps, h, w);
                }
            }
        }
    }
​
    private static bool IsCanGo(int y, int x, int h, int w)
    {
        if (y < 0 || y >= h || x < 0 || x >= w)
            return false;
​
        return true;
    }
}