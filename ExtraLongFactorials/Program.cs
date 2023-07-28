long n = Convert.ToInt64(Console.ReadLine().Trim());

Console.WriteLine(extraLongFactorials(n));

long extraLongFactorials(long n)
{
    // Base case
    if(n == 1) return n;

    // Recursive case
    return n*extraLongFactorials(n - 1);
}