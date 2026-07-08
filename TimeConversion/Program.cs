// See https://aka.ms/new-console-template for more information

string date = Console.ReadLine() ?? string.Empty;
var convertedTime = timeConversion(date);

static string timeConversion(string date){
    var timeOfTheDay = date.Substring(8);
    var hour = date.Substring(0, date.Length - 2);
    var correctDateFormat = $"{hour} {timeOfTheDay}";

    var parsedDate = DateTime.Parse(correctDateFormat);

    return parsedDate.ToString("HH:mm:ss");
}