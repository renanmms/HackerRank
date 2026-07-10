using Xunit;

namespace GradingStudentsTests;

public class ResultTests
{
    
    [Theory]
    [InlineData(29)]
    [InlineData(33)]
    [InlineData(37)]
    [InlineData(0)]
    public void Grade_IsFailingGradeLessThan38_DoNotRound(int grade)
    {
        var result = Result.RoundGrade(grade);

        Assert.Equal(grade, result);
    }

    [Theory]
    [InlineData(39, 40)]
    [InlineData(84, 85)]
    public void Grade_IsGradeGreaterThan38_DoRound(int grade, int expected)
    {        
        var result = Result.RoundGrade(grade);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(57)]
    [InlineData(42)]
    [InlineData(76)]
    [InlineData(96)]
    public void Grade_DifferenceBetweenTheGradeAndTheNextMultipleOfFive_DoNotRound(int grade)
    {
        var result = Result.RoundGrade(grade);

        Assert.Equal(grade, result);
    }

}
