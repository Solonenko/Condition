using System;

namespace Condition
{
    public static class Condition
    {
        public static int Task1(int n)
        {
            if (n > 0)
            {
               return n * n;
            }
            if (n < 0)
            {
                return -1 * n;
            }
            if (n == 0)
            {
                return 0;
            }
            return n;
        }


        public static int Task2(int n)
        {
            int c = n % 10;
            int a = n / 100;
            int b = (n - a * 100 - c) / 10;

            if (a > b && a > c && b >= c)
            {
                return a * 100 + b * 10 + c;
            }
            if (a > b && a > c && b < c)
            {
                return a * 100 + c * 10 + b;
            }
            if (b > a && b > c && a >= c)
            {
                return b * 100 + a * 10 + c;
            }
            if (b > a && b > c && a < c)
            {
                return b * 100 + c * 10 + a;
            }
            if (c > a && c > b && a >= b)
            {
                return c * 100 + a * 10 + b;
            }
            if (c > a && c > b && a < b)
            {
                return c * 100 + b * 10 + a;
            }
            if (a == b && a == c)
            {
                return a * 100 + b * 10 + c;
            }
            return n;
        }
    }
}
