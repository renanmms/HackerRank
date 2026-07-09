string[] firstMultipleInput = (Console.ReadLine() ?? string.Empty).TrimEnd().Split(' ');

int n = Convert.ToInt32(firstMultipleInput[0]);
int k = Convert.ToInt32(firstMultipleInput[1]);

List<int> height = (Console.ReadLine() ?? string.Empty).TrimEnd().Split(' ').ToList().Select(heightTemp => Convert.ToInt32(heightTemp)).ToList();

int result = hurdleRace(k, height);


static int hurdleRace(int k, List<int> height)
{
    var maxHurdleHeight = height.Max();

    if(maxHurdleHeight <= k)
    {
        return 0;
    }
    
    return maxHurdleHeight - k;
}