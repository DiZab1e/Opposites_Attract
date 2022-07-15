using System;
using System.Linq;

public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    {
        int x = flower1 % 2;
        int z = flower2 % 2;
        if ((x == 0 || z != 0) ^ (x != 0 || z == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }