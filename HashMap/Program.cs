int[] nums = { 1, 2, 3, 4, 3 };

bool result = ContainsDuplicate(nums);

Console.WriteLine(result);

Console.ReadKey();

bool ContainsDuplicate(int[] nums)
{

    var seen = new HashSet<int>();

    foreach(var x in nums)
    {
        if(seen.Contains(x))
        {
            return true;
        }

        seen.Add(x);
    }

    return false;
}

