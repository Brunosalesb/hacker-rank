// static List<int> CompareTriplets(List<int> a, List<int> b)
// {
//     var alicePoints = 0;
//     var bobPoints = 0;
//
//     for (var i = 0; a.Count > i; i++)
//     {
//         if (a[i] > b[i])
//             alicePoints++;
//
//         else if (a[i] < b[i])
//             bobPoints++;
//     }
//
//     return new List<int> { alicePoints, bobPoints };
// }
//
//
// List<int> a = [5, 6, 7];
//
// List<int> b = [3, 6, 10];
//
// List<int> result = CompareTriplets(a, b);
//
// Console.WriteLine(String.Join(" ", result));