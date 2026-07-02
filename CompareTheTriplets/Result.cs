internal class Result
{
    /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     
        If a[i] > b[i], then Alice is awarded 1 point.
        If a[i] < b[i], then Bob is awarded 1 point.
        If a[i] = b[i], then neither person receives a point.


        int a[3]: Alice's challenge rating
        int b[3]: Bob's challenge rating

        Returns
        int[2]: the first element is Alice's score and the second is Bob's score

     *  2. INTEGER_ARRAY b
     */

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int alicePoints = 0;
        int bobPoints = 0;

        for(int i = 0; i < 3; i++)
        {
            if(a[i] > b[i]) alicePoints++;
            if(a[i] < b[i]) bobPoints++;
        }

        return new List<int>{alicePoints, bobPoints};
    }
}