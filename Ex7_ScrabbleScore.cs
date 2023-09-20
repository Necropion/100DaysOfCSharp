using System;

public static class ScrabbleScore
{
    public static int Score(string input) {

        input = input.ToUpper();
        char[] inputWord = input.ToCharArray();

        int scrabbleScore = 0;

        for (int i = 0; i < inputWord.Length; i++) {

            switch (inputWord[i]) {
                
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                case 'L':
                case 'N':
                case 'R':
                case 'S':
                case 'T':
                    scrabbleScore++;
                    break;
                case 'D':
                case 'G':
                    scrabbleScore += 2;
                    break;
                case 'B':
                case 'C':
                case 'M':
                case 'P':
                    scrabbleScore += 3;
                    break;
                case 'F':
                case 'H':
                case 'V':
                case 'W':
                case 'Y':
                    scrabbleScore += 4;
                    break;
                case 'K':
                    scrabbleScore += 5;
                    break;
                case 'J':
                case 'X':
                    scrabbleScore += 8;
                    break;
                case 'Q':
                case 'Z':
                    scrabbleScore += 10;
                    break;
            }
        }

        return scrabbleScore;
    }
}