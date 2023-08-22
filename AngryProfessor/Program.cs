var numberTestCases = 1;
var cancellationThreshold = 3;
var arrivalTimes = new int[]{-2, 1, 0, 1, 2};
var attendees = 0;

foreach(var time in arrivalTimes)
{
    if(time <= 0) attendees++;
}

Console.WriteLine(attendees);