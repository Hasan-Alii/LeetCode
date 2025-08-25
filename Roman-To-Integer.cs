public class Solution {
    public int RomanToInt(string s) {
        Hashtable romanToInt = new Hashtable();
romanToInt.Add("I", 1);
romanToInt.Add("V", 5);
romanToInt.Add("X", 10);
romanToInt.Add("L", 50);
romanToInt.Add("C", 100);
romanToInt.Add("D", 500);
romanToInt.Add("M", 1000);
romanToInt.Add("CM", 900);
romanToInt.Add("CD", 400);
romanToInt.Add("XC", 90);
romanToInt.Add("XL", 40);
romanToInt.Add("IV", 4);
romanToInt.Add("IX", 9);

int total = 0;
for (int i = 0; i < s.Length; i++)
{
    string ss = "";
    if (i + 1 < s.Length)
        ss = s[i].ToString() + s[i+1].ToString();

    if (romanToInt.ContainsKey(ss))
    {
        total += (int)romanToInt[ss]!;
        i++;
    }
    else if (romanToInt.ContainsKey(s[i].ToString()))
    {
        total += (int)romanToInt[s[i].ToString()]!;
    }
} 
return total;
    }
}
