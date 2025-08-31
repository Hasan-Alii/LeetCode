public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0) return false;
        int res = 0, number = x;
        while (number > 0){
            int digit = number % 10; // this gets the last digit of a number (form the right)
            res = res * 10 + digit;
            number /= 10;
        }
        if (x == res)
            return true;
        return false;
    }
}
