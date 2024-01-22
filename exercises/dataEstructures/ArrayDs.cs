static List<int> ReverseArray(List<int> a)
{
    a.Reverse();
    return a;
}


List<int> arr = [1, 4, 3, 2];

List<int> res = ReverseArray(arr);

Console.WriteLine(String.Join(" ", res));