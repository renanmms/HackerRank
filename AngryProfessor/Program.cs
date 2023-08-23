var numberTestCases = 1;
var cancellationThreshold = 3;
var studentsArrivalTimes = new List<int>{-2, -1, 0, 1, 2};

Console.WriteLine(angryProfessor(cancellationThreshold, studentsArrivalTimes));

string angryProfessor(int k, List<int> a)
{
    var studentsArrivedInTime = 0;

    foreach(var time in a){
        if(time <= 0) ++studentsArrivedInTime;
    }

    if(studentsArrivedInTime < k) return "YES";
    else return "NO";
}