// [문제 링크]: https://school.programmers.co.kr/learn/courses/30/lessons/159994

using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        
        var index1 = 0;
        var index2 = 0;
        var goalIndex = 0;
        
        while(goalIndex < goal.Length)
        {
            var isCorrect = false;
            
            if(index1 < cards1.Length && cards1[index1] == goal[goalIndex])
            {
                index1++;
                isCorrect = true;
            }
            else if(index2 < cards2.Length && cards2[index2] == goal[goalIndex])
            {
                index2++;
                isCorrect = true;
            }
           
            if(!isCorrect)
                return "No";
            
            goalIndex++;
        }
        
        
        return "Yes";
    }
}