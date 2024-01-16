static void MiniMaxSum(List<int> arr)
{
    arr.Sort();
    var minSum = arr.Take(4).Select(Convert.ToInt64).Sum();
    var maxSum = arr.Skip(1).Select(Convert.ToInt64).Sum();

    Console.WriteLine($"{minSum} {maxSum}");
}


List<int> arr = [1, 2, 3, 4, 5];

MiniMaxSum(arr);