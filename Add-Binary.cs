public class Solution {
    public string AddBinary(string a, string b) {
                string result = "";
        int carry = 0;
        for (int i = 0; i <Math.Max(a.Length, b.Length); i++)
        {
            int valA = a.Length > i ? a[a.Length-1 - i] -'0' : 0;
            int valB = b.Length > i ? b[b.Length-1 - i] -'0' : 0;
            int total = valA + valB + carry;
            result = (total % 2).ToString() + result;
            carry = total / 2;
        }
        if(carry != 0)
            result = carry.ToString() + result;
        return result;
    }
}
