namespace CodeChallenge;

public static class Class1
{
    public static String OldPhonePad(string input) {
        var keypad = new Dictionary<char, string[]>()
        {
            { '2', ["A", "B", "C"] },
            { '3', ["D", "E", "F"] },
            { '4', ["G", "H", "I"] },
            { '5', ["J", "K", "L"] },
            { '6', ["M", "N", "O"] },
            { '7', ["P", "Q", "R", "S"] },
            { '8', ["T", "U", "V"] },
            { '9', ["W", "X", "Y", "Z"] }
        };

        string output = "";

        char previousChar = 'X';
        int repeatCount = 0;

        foreach(char c in input){
            if (c.Equals('#')) {
                if (! previousChar.Equals('X')) {
                    output = output + keypad[previousChar][repeatCount];
                }
                break;
            } else if (c.Equals('*')) {
                output = output[..^1];
            } else if (Char.IsDigit(c)) {
                if (c == previousChar) {
                    repeatCount++;
                } else {
                    if (! previousChar.Equals('X')) {
                        output = output + keypad[previousChar][repeatCount];
                    }
                }
                previousChar = c;
            }
        }

        return output;
    }
}
