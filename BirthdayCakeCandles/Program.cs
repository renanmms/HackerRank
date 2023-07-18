var candlesHeight = new List<int>(){4, 4, 1, 3};

Console.WriteLine(birthdayCakeCandles(candlesHeight));

int birthdayCakeCandles(List<int> candlesHeight){
    var tallestCandle = candlesHeight.Max();
    
    return candlesHeight.Where(c => c == tallestCandle).Count();
}