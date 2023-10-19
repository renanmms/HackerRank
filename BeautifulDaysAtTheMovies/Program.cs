int k = 6;

for(int i = 20; i <= 23; i++) 
{
    var givenNumber = i;
    var reversedNumber = Convert.ToInt32(string.Join("", i.ToString().Reverse()));

    if((givenNumber - reversedNumber) % k == 0)
    {
        Console.WriteLine($"{i} is a beautiful day");
    }
}