int[] nums = { 2, 7, 11, 15 };
int target = 9;

int[] result = TwoSum(nums, target);

Console.WriteLine($"Index 1: {result[0]}");
Console.WriteLine($"Index 2: {result[1]}");

static int[] TwoSum(int[] nums, int target)
{
    var map = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        int needed = target - nums[i];

        if (map.TryGetValue(needed, out int index))
        {
            return new[] { index, i };
        }

        map[nums[i]] = i;
    }
    return Array.Empty<int>();

}