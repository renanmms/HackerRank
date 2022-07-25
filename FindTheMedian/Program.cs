// See https://aka.ms/new-console-template for more information

Console.WriteLine("Find Median");
var arr = new List<int>{5,3,1,2,4};

Console.WriteLine(findMedian(arr));

static int findMedian(List<int> arr){
    arr.Sort();
    var median = arr[(arr.Count() - 1)/2];
    return median;
}