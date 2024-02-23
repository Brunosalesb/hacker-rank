using System.Diagnostics;

static int[] SolutionOne(int[] arr, int target)
{
    var result = Array.Empty<int>();
    
    for (var i = 0; arr.Length > i; i++)
    {
        var firstValue = arr[i];

        for (var n = i + 1; n < arr.Length; n++)
        {
            var secondValue = arr[n];
            var sum = firstValue + secondValue;
            if (sum != target || firstValue == secondValue) 
                continue;
            
            return [i, n];
        }
    }

    return result;
}

static int[] SolutionTwo(int[] arr, int target)
{
    var result = Array.Empty<int>();
    
    for (var i = 0; arr.Length > i; i++)
    {
        var firstValue = arr[i];

        for (var n = arr.Length - 1; n < arr.Length; n--)
        {
            var secondValue = arr[n];
            var sum = firstValue + secondValue;

            if (sum > target)
                continue;

            if (sum < target)
                break;
            
            if (firstValue == secondValue) 
                continue;
            
            return [i, n];
        }
    }
    
    return result;
}

static int[] SolutionThree(int[] arr, int target)
{
    var result = Array.Empty<int>();
    var dic = new Dictionary<int, int>();

    for (var i = 0; i < arr.Length; i++)
    {
        if (dic.ContainsValue(arr[i]))
            return [dic.FirstOrDefault(x => x.Value == arr[i]).Key, i];
        
        dic.Add(i, target - arr[i]);
    }

    return result;
}


int[] arr = [1, 3, 5, 8, 2];
var target = 6;
var result = SolutionOne(arr, target);
var result2 = SolutionTwo(arr, target);
var result3 = SolutionThree(arr, target);
Console.WriteLine(string.Join(",", result));
Console.WriteLine(string.Join(",", result2));
Console.WriteLine(string.Join(",", result3));