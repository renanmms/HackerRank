int arCount = Convert.ToInt32(Console.ReadLine().Trim());
List<long> ar = Console.ReadLine()?.TrimEnd().Split(' ')?.ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList()!;
long result = aVeryBigSum(ar);

Console.WriteLine(result);

static long aVeryBigSum(List<long> arr){
    return arr.Sum();
}