using System;

public class Question1
{
    public static int MaxSequence(int[] arr)
    {
        // return 0 if array is empty
        if (arr == null || arr.Length == 0)
        {
            return 0;
        }
        
        // if array is not empty or contains only negative number, the best sum of numbers must be >= 0
        int bestSum = 0;
        int curSum = 0;

        foreach (int num in arr)
        {
            //loop through each number in array
            curSum += num;

            //when sum < 0 , the current ongoing sum loop is not ideal anymore, start new sum loop
            if (curSum < 0)
            {
                curSum= 0;
            }

            if (curSum> bestSum)
            {
                bestSum = curSum;
            }
        }

        return bestSum;
    }
}