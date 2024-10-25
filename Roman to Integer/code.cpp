public class Solution {
    public int RomanToInt(string s) {
        int result = 0;
        int i = 0;
        while (i < s.Length) {
            if (i < s.Length - 1) {
                if (checkValue(s[i].ToString()) < checkValue(s[i+1].ToString())) {
                    result += (checkValue(s[i+1].ToString()) - checkValue(s[i].ToString()));
                    i++;
                }
                else {
                    result += checkValue(s[i].ToString());
                }
            }
            else {
                result += checkValue(s[i].ToString());
            }
            i++;
        }
        
        int checkValue(string roman) {
            switch (roman) {
                case "I":
                    return 1;
                case "V":
                    return 5;
                case "X":
                    return 10;
                case "L":
                    return 50;
                case "C":
                    return 100;
                case "D":
                    return 500;
                case "M":
                    return 1000;
                default:
                    return 0;
            }
        }

        return result;
    }
}
