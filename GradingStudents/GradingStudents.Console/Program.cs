using System.Data;

int gradesCount = Convert.ToInt32((Console.ReadLine() ?? string.Empty).Trim());

List<int> grades = [];

for (int i = 0; i < gradesCount; i++)
{
    int gradesItem = Convert.ToInt32((Console.ReadLine() ?? string.Empty).Trim());
    grades.Add(gradesItem);
}

List<int> result = Result.gradingStudents(grades);

Console.WriteLine(string.Join("\n", result));


public class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        var roundedGrades = new List<int>(grades.Count);

        return roundedGrades.ConvertAll(RoundGrade);
    }

    public static int RoundGrade(int grade)
    {
        if(grade < 38)
        {
            return grade;
        }

        int nextMultipleOfFive = grade + (5 - (grade % 5));
        int difference = nextMultipleOfFive - grade;

        if(difference < 3)
        {
            return nextMultipleOfFive;
        }

        return grade;
    }
}