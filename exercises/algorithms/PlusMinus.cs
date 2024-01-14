// static void PlusMinus(List<int> arr)
// {
//     var quantityPositive = 0;
//     var quantityNegative = 0;
//     var quantityZeros = 0;
//
//     foreach (var item in arr)
//     {
//         if (item < 0)
//             quantityNegative++;
//         else if (item > 0)
//             quantityPositive++;
//         else
//             quantityZeros++;
//     }
//
//     var results = new List<double>();
//
//     results.Add((double)quantityPositive / arr.Count);
//     results.Add((double)quantityNegative / arr.Count);
//     results.Add((double)quantityZeros / arr.Count);
//
//     foreach (var result in results)
//     {
//         Console.WriteLine(result.ToString("0.000000"));
//     }
// }
//
//
// List<int> arr = [-4, 3, -9, 0, 4, 1];
// PlusMinus(arr);