public class Solution {
    public IList<int> GetRow(int rowIndex) {
        if (rowIndex < 0 || rowIndex > 33)
    return Array.Empty<int>();

IList<IList<int>> result = new List<IList<int>>();

result.Add(new List<int>());

result[0].Add(1);
for (int i = 1; i <= rowIndex; i++)
{
    result.Add(new List<int>());
    result[i].Add(1);
    for (int j = 1; j < i; j++)
    {
        int val = result[i - 1][j] + result[i - 1][j - 1];
        result[i].Add(val);
    }
    result[i].Add(1);
}
return result[rowIndex];
    }
}
