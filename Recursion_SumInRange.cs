using System;

class Recursion
{
    static void Main()
    {
        int x = 1;
        int y = 5;

        int sum = SumInRange(x, y);
        Console.WriteLine($"Sum of numbers from {x} to {y} is: {sum}");
    }

    static int SumInRange(int start, int end)
    {
        if (start > end)
        {
            return 0;
        }
        else
        {
            return start + SumInRange(start + 1, end);
        }
    }
}
