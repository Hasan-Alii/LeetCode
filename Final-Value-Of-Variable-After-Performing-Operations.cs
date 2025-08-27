public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int x = 0;
        foreach(var item in operations){
            if(item =="X++" || item =="++X")
                x++;
            if(item =="X--" || item =="--X")
                x--;
        }
        return x;
    }
}
