// See https://aka.ms/new-console-template for more information

string key = "33333555"; 
Console.WriteLine(key);

bool isDecentNumber = IsDecentNumber(key);

bool IsDecentNumber(string key)
{
	if((key.Contains('5') || key.Contains('3')) && 
	   CountDigitOccurences(key, '3') % 5 == 0 &&
	   CountDigitOccurences(key, '5') % 3 == 0)
	{
		Console.WriteLine($"{key} is a decent number and has length of {key.Length}");
		return true;
	}
	return false;
}

int CountDigitOccurences(string key, char digit)
{
	int occurences = key.Where(c => c == digit).Count();

	return occurences;
}