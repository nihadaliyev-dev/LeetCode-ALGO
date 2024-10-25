function romanToInt(s) {
    let result = 0;
    
    for (let i = 0; i < s.length; i++) {
        if (i < s.length - 1) {
            if (checkValue(s[i]) < checkValue(s[i + 1])) {
                result += (checkValue(s[i + 1]) - checkValue(s[i]));
                i++;
            } else {
                result += checkValue(s[i]);
            }
        } else {
            result += checkValue(s[i]);
        }
    }
    
    function checkValue(roman) {
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
