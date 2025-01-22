namespace CodeChallenge;

public static class Class1
{
    public static String OldPhonePad(string input) {
        var keypad = new Dictionary<string, string[]>()
        {
            { "2", ["A", "B", "C"] },
            { "3", ["D", "E", "F"] },
            { "4", ["G", "H", "I"] },
            { "5", ["J", "K", "L"] },
            { "6", ["M", "N", "O"] },
            { "7", ["P", "Q", "R", "S"] },
            { "8", ["T", "U", "V"] },
            { "9", ["W", "X", "Y", "Z"] }
        };

        var output = "";

        foreach(char c in input){
            if (c.Equals('#')) {
                break;
            } else if (c.Equals("*")) {
                output = output[..^1];
            } else if (Char.IsDigit(c)) {
                output = output + 'X';
            }
        }

        return output;
    }
}
