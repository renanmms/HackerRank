// See https://aka.ms/new-console-template for more information



var matrix =  new List<List<int>>();
var list1 = new List<int>{11, 2, 4};
var list2 = new List<int>{4, 5, 6};
var list3 = new List<int>{10, 8, -12};

matrix.Add(list1);
matrix.Add(list2);
matrix.Add(list3);

Console.WriteLine(diagonalDifference(matrix, 3));

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