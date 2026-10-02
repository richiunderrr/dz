using System;
using System.Collections.Generic;


public class Main
{
    public static int Min(int a, int b)
    {
        if (a < b)
            return a;

        return b;
    }

    public static int Max(int a, int b)
    {
        if (a > b)
            return a;

        return b;
    }
}