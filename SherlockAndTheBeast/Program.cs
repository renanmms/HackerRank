// See https://aka.ms/new-console-template for more information

string key = "33333555"; 
Console.WriteLine(key);

bool isDecentNumber = IsDecentNumber(key);

bool IsDecentNumber(string key)
{
	var keyIsValid = IsValid(key);
	if(keyIsValid)
	{
		Console.WriteLine($"{key} is a decent number and has length of {key.Length}");
	}
	return keyIsValid;
}

int CountDigitOccurences(string key, char digit)
{
	return key.Count(c => c == digit);
}

bool IsValid(string key) {
	return (key.Contains('5') || key.Contains('3')) && 
	   CountDigitOccurences(key, '3') % 5 == 0 &&
	   CountDigitOccurences(key, '5') % 3 == 0;
}