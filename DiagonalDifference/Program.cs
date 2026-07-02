// See https://aka.ms/new-console-template for more information

var input = Console.ReadLine() ?? string.Empty;
int n = Convert.ToInt32(input.Trim());

List<List<int>> arr = new List<List<int>>();

for (int i = 0; i < n; i++)
{
    arr.Add((Console.ReadLine() ?? string.Empty).TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
}

Console.WriteLine(diagonalDifference(arr, n));

static int diagonalDifference(List<List<int>> arr, int n)
{
    int rightToLeftDiagonal = 0;
    int leftToRightDiagonal = 0;
    for(int i = 0; i < n; i++){
        for(int j = 0; j < n; j++){
            if(i == j){
                leftToRightDiagonal += arr[i][j];
            }
            if((i + j) == n - 1){
                rightToLeftDiagonal += arr[i][j];
            }
        }
    }
    return Math.Abs(rightToLeftDiagonal - leftToRightDiagonal);
}