var arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();
miniMaxSum(arr);

void miniMaxSum(List<long> arr)
{
    var maximumSum = arr.Where(n => n != arr.Min()).Sum();
    var minimumSum = arr.Where(n => n != arr.Max()).Sum();

    Console.Write("{0} {1}", minimumSum, maximumSum);
}