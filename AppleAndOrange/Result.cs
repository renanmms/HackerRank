public class Result
{
    /*
     * Complete the 'countApplesAndOranges' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER s - Sam's House Starting Point
     *  2. INTEGER t - Sam's House Ending Point
     *  3. INTEGER a - Apple Tree Point
     *  4. INTEGER b - Orange Tree Point
     *  5. INTEGER_ARRAY apples
     *  6. INTEGER_ARRAY oranges
     */

    public static void CountApplesAndOranges(int houseStartingPoint,
        int houseEndingPoint,
        int appleTreePoint,
        int orangeTreePoint,
        List<int> apples,
        List<int> oranges)
    {
        int numberOfApplesLanded = CountLandedFruits(appleTreePoint,
            houseStartingPoint,
            houseEndingPoint,
            apples);

        int numberOfOrangesLanded = CountLandedFruits(orangeTreePoint,
            houseStartingPoint,
            houseEndingPoint,
            oranges);

        Console.WriteLine(numberOfApplesLanded);
        Console.WriteLine(numberOfOrangesLanded);
    }

    private static int CountLandedFruits(int treePoint,
        int houseStartingPoint,
        int houseEndingPoint,
        List<int> fruits)
    {
        int numberOfLandedFruits = fruits.Count(
            d => FruitHasLandedOnHouse(treePoint + d, houseStartingPoint, houseEndingPoint));

        return numberOfLandedFruits;
    }

    private static bool FruitHasLandedOnHouse(int currentFruitLanded, int houseStartingPoint, int houseEndingPoint)
    {
        return currentFruitLanded >= houseStartingPoint &&
            currentFruitLanded <= houseEndingPoint;
    }
}