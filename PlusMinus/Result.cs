internal class Result
{
    private static int _negatives;
    private static int _positives;
    private static int _zeros;
    private static int _arrSize;
    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        _arrSize = arr.Count;

        foreach(int n in arr)
        {
            if(n > 0) _positives++;
            if(n < 0) _negatives++;
            if(n == 0) _zeros++;
        }

        printRatio();
    }

    private static decimal calculateRatio(int n)
    {
        return Math.Round((decimal)n / _arrSize, 6);
    }

    private static void printRatio()
    {
        Console.WriteLine(calculateRatio(_positives).ToString("F6"));
        Console.WriteLine(calculateRatio(_negatives).ToString("F6"));
        Console.WriteLine(calculateRatio(_zeros).ToString("F6"));
    }
}