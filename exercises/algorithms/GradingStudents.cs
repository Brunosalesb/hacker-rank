// static List<int> GradingStudents(List<int> grades)
// {
//     var result = new List<int>();
//
//     foreach (var grade in grades)
//     {
//         if (grade < 38)
//         {
//             result.Add(grade);
//         }
//         else
//         {
//             var nextMultipleOf5 = (int)Math.Ceiling((double)grade / 5) * 5;
//             result.Add(nextMultipleOf5 - grade < 3 ? nextMultipleOf5 : grade);
//         }
//     }
//
//     return result;
// }
//
//
// List<int> grades = [73, 67, 38, 33];
//
//
// List<int> result = GradingStudents(grades);
//
// Console.WriteLine(String.Join("\n", result));