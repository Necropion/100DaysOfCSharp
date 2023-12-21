using System;
using System.Linq;

public static class Bob {

    public static string Response(string statement) {

        char[] disectStatement = statement.Trim().ToCharArray();
        string lettersOnly = new string(statement.Where(char.IsLetter).ToArray());
        char[] disectLetters = lettersOnly.ToCharArray();

        bool isQuestion = false;
        bool isYelling = false;
        
        if (disectStatement.Length != 0) {
            isQuestion = disectStatement[disectStatement.Length - 1].ToString() == "?";
        }

        if (disectLetters.Length != 0) {
            isYelling = true;
            
            for (var n = 0; n < disectLetters.Length; n++) {

                if (char.IsLower(disectLetters[n])) {

                    isYelling = false;
                }
            }
        }
        
        if (isQuestion && isYelling) {
            return "Calm down, I know what I'm doing!";
        }
        
        if(isQuestion) {
            return "Sure.";
        }

        if (isYelling) {
            return "Whoa, chill out!";
        }

        if (disectStatement.Length == 0) {
            return "Fine. Be that way!";
        }
        
        return "Whatever.";
    }
}