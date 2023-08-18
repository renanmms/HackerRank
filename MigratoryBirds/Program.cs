var arr = new List<int> {1, 1, 2, 2, 3};

var mostFreqBirdType = migratoryBirds(arr);

Console.WriteLine(mostFreqBirdType);

int migratoryBirds(List<int> arr){
    var countingArr = new List<int>(5);

    for(int i = 0; i < 5; i++)
    {
        countingArr.Add(arr.Count(n => n == i + 1));
    }

    var max = countingArr.Max();
    var hasMoreThanOneValue = countingArr.Count(n => n == max) > 1;
    return countingArr.IndexOf(max) + 1;
}