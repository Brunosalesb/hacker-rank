static int HourglassSum(List<List<int>> arr)
{
    var max = int.MinValue;

    for (var row = 0; row < 4; row++)
    {
        for (var col = 0; col < 4; col++)
        {
            var total = arr[row][col] + arr[row][col + 1] + arr[row][col + 2];
            total += arr[row + 1][col + 1];
            total += arr[row + 2][col] + arr[row + 2][col + 1] + arr[row + 2][col + 2];
            max = total > max ? total : max;
        }
    }

    return max;
}


List<List<int>> arr =
[
    [1, 1, 1, 0, 0, 0],
    [0, 1, 0, 0, 0, 0],
    [1, 1, 1, 0, 0, 0],
    [0, 0, 2, 4, 4, 0],
    [0, 0, 0, 2, 0, 0],
    [0, 0, 1, 2, 4, 0]
];

int result = HourglassSum(arr);
Console.WriteLine(result);