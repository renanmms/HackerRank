// See https://aka.ms/new-console-template for more information

string date = Console.ReadLine();

var convertedTime = timeConversion(date);

Console.WriteLine(convertedTime);

static string timeConversion(string date){
    var correctDateFormat = $"{date.Substring(0, date.Length - 2)} {date.Substring(8)}";
    var parsedDate = DateTime.Parse(correctDateFormat);
    return parsedDate.ToString().Split()[1];
}