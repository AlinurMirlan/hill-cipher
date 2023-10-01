using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillCipher.Library;

public static class Gcd
{
    public static int CommonDivisor(int a, int b)
    {
        if (a == 0)
            return b;

        return CommonDivisor(b % a, a);
    }

    /// <summary>
    /// Extended Euclidean Algorithm finds integer coefficients x and y such that: ax + by = gcd(a, b) 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public static int CommonDivisorExtended(int a, int b, ref int x, ref int y)
    {
        // Base Case
        if (a == 0)
        {
            x = 0;
            y = 1;
            return b;
        }

        // To store results of
        // recursive call
        int x1 = 1, y1 = 1;
        int gcd = CommonDivisorExtended(b % a, a, ref x1, ref y1);

        // Update x and y using
        // results of recursive call
        x = y1 - (b / a) * x1;
        y = x1;

        return gcd;
    }
}
