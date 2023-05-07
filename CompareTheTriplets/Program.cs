(int clarity, int originality, int difficulty) alice = (0, 0, 0);
(int clarity, int originality, int difficulty) bob = (0, 0, 0);;

var aliceChallengesRate = Console.ReadLine()!.Split(" ");
var bobChallengesRate = Console.ReadLine()!.Split(" ");

// TODO: Get challenge rates and store in the tuples

Console.WriteLine(GetComparisonPoints(alice, bob));


(int, int) GetComparisonPoints((int clarity, int originality, int difficulty) a1,
                        (int clarity, int originality, int difficulty) b1){    
    var comparisonPoints = (0, 0);

    comparisonPoints.Item1 += a1.clarity > b1.clarity ? 1 : 0;
    comparisonPoints.Item1 += a1.originality > b1.originality ? 1 : 0;
    comparisonPoints.Item1 += a1.difficulty > b1.difficulty ? 1 : 0;

    comparisonPoints.Item2 += b1.clarity > a1.clarity ? 1 : 0;
    comparisonPoints.Item2 += b1.originality > a1.originality ? 1 : 0;
    comparisonPoints.Item2 += b1.difficulty > a1.difficulty ? 1 : 0;

    return comparisonPoints;
}