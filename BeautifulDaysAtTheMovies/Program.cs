
var line = Console.ReadLine()
                  .TrimEnd()
                  .Split(' ')
                  .Select(n => Convert.ToInt32(n))
                  .ToList();

Console.WriteLine(calculateNumberOfBeautifulDays(line[0], line[1], line[2]));

int calculateNumberOfBeautifulDays(int i, int j, int k)
{
    int numberBeautifulDays = 0;

    for(; i <= j; i++)
    {
        var givenNumber = i;
        var reversedNumber = Convert.ToInt32(string.Join("", i.ToString().Reverse()));

        if(Math.Abs(givenNumber - reversedNumber) % k == 0) numberBeautifulDays++;
    }

    return numberBeautifulDays;
}