// See https://aka.ms/new-console-template for more information

string key = "33355555"; 

bool isDecentNumber = IsDecentNumber(key);

bool IsDecentNumber(string key)
{
	if(key.Contains('5') && key.Contains('3'))
	{
		Console.WriteLine($"{key} is a decent number");
		Console.WriteLine($"Number of occurences of the number 3: {CountDigitOccurences(key, '3')}");
		Console.WriteLine($"Number of occurences of the number 5: {CountDigitOccurences(key, '5')}");
		return true;
	}
	return false;
}

int CountDigitOccurences(string key, char digit)
{
	int occurences = key.Where(c => c == digit).Count();

	return occurences;
}