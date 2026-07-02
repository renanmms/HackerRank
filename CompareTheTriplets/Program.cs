List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

List<int> result = Result.compareTriplets(a, b);

Console.WriteLine($"Challenge rating: ({result[0]}, {result[1]})");