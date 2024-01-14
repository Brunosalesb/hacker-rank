// int DiagonalDifference(List<List<int>> arr)
// {
//     var diagonalPrimary = 0;
//     var diagonalSecondary = 0;
//     var n = arr.Count;
//
//     for (var i = 0; i < n; i++)
//     {
//         diagonalPrimary += arr[i][i];
//
//         diagonalSecondary += arr[i][n - i - 1];
//     }
//
//     var difference = Math.Abs(diagonalPrimary - diagonalSecondary);
//
//     return difference;
// }
//
//
// List<List<int>> arr = [[11, 2, 4], [4, 5, 6], [10, 8, -12]];
// int result = DiagonalDifference(arr);
//
// Console.WriteLine(result);