var arr = (Console.ReadLine() ?? string.Empty)
    .TrimEnd()
    .Split(' ')
        .ToList()
    .Select(arrTemp => Convert.ToInt64(arrTemp))
        .ToList();

miniMaxSum(arr);

void miniMaxSum(List<long> arr)
{
    var sorted = arr.Order();
    var miniSum = sorted.Take(4).Sum();
    var maxSum = sorted.TakeLast(4).Sum();

    Console.Write("{0} {1}", miniSum, maxSum);
}

// Me overcomplicating things XD

// void miniMaxSum(List<long> arr)
// {
//     var minimumValue = arr.Min();
//     var maximumValue = arr.Max();

//     var isNormalized = minimumValue == maximumValue;

//     var numberOfMinValues = arr.Where(n => n == minimumValue);
//     var numberOfMaxValues = arr.Where(n => n == maximumValue);

//     if(isNormalized)
//     {
//         var miniMaxSum = minimumValue + maximumValue;
//         Console.WriteLine("{0} {1}", miniMaxSum, miniMaxSum);
//         return;
//     }

//     var maxSum = arr.Where(n => n != minimumValue).Sum();
//     var miniSum = arr.Where(n => n != maximumValue).Sum();

//     Console.Write("{0} {1}", miniSum, maxSum);
// }