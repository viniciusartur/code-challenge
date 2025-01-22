namespace CodeChallenge;

public static class CodingChallenge
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
            if (c != previousChar && Char.IsDigit(previousChar)) {
                output = output + keypad[previousChar][repeatCount];
                repeatCount = 0;
            }
            if (c.Equals('#')) {
                break;
            } else if (c.Equals(' ')) {
                previousChar = 'X';
            } else if (c.Equals('*')) {
                output = output[..^1];
                previousChar = 'X';
            } else if (Char.IsDigit(c)) {
                if (c == previousChar) {
                    repeatCount++;
                }
                previousChar = c;
            }
        }

        return output;
    }
}
