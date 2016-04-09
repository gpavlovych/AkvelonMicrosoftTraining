﻿namespace Week1
{
    /// <summary>
    /// Give a one-line expression to check whether the number is the power of 2
    /// </summary>
    public static class Task42
    {
        public static bool IsPowerOf2(long number)
        {
            return (number > 0) && ((number & (number - 1)) == 0);
        }
    }
}
