// IEnumerable (GetEnumerator(), inherit)
// yield return
// Extension methods
// Recreating default methods Where, FirstOrDefault, ...

using Yield_Return;

string[] words = { "adsad", "sdasdsa", "qqqqe" };
Console.WriteLine(words.MyCount());

Console.WriteLine("----------------");

int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
foreach (int num in nums.MyWhere(i => i % 2 == 0))
{
    Console.WriteLine(num);
}

Console.WriteLine("----------------");

Console.WriteLine(nums.MyFirst(i => i % 2 == 0));

Console.WriteLine("----------------");

Console.WriteLine(nums.MyCountOf(i => i % 2 == 0));

Console.WriteLine("----------------");

Console.WriteLine(nums.MyLast(i => i % 2 == 0));