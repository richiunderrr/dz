using System;
using System.Collections.Generic;


public class Main
{
    public static int Min(int[] numbers)
    {
        int min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
                min = numbers[i];
        }
        return min;
    }
    public static int Max(int[] numbers)
    {
        int Max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > Max)
                Max = numbers[i];
        }

        return Max;
    }
    
}