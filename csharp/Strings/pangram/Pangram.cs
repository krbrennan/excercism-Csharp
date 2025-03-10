public static class Pangram
{

    // one option would be to split the input to a char array, capture the distinct letters, and if the length is equal to a pre-defined array of the alphabet, then it must be a pangram, otherwise false

    public static char[] LowercaseLetters = new char[26];

    public static void generateAlphabet()
    {

        for (int i = 0; i < 26; i++)
	    {
            // add each letter to the lowercaseLetters ary
            LowercaseLetters[i] = (char)('a'+ i);
	    }
    }

    public static bool IsPangram(string input)
    {
        generateAlphabet();

        if(input == "")
        {
            return false;
        }

        string trimmedInput = input.Replace(" ", "").ToLower();
        char[] inputChars = trimmedInput.Where(l => char.IsLetter(l)).ToArray();
        char[] distinctInputChars = inputChars.Distinct().ToArray();
        return LowercaseLetters.Length == distinctInputChars.Length;
    }
}
