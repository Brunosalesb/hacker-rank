static List<int> RotateLeft(int d, List<int> arr)
{
    var numbers = arr.Take(d);
    var newArr = arr.Skip(d).ToList();
    newArr.AddRange(numbers);
    return newArr;
}


int d = 2;
List<int> arr = [1, 2, 3, 4, 5];
List<int> result = RotateLeft(d, arr);
Console.WriteLine(String.Join(" ", result));