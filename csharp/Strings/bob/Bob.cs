using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

public static class Bob
{
    public static string Response(string statement)
    {
        //"Sure" if question
        //"Whoa, chill out!" if yell at bob
        // "Calm down, I know what I'm doing!" if yell question
        // "Fine. Be that way!" if nothing said
        // "Whatever" for everything else

        char[] articulatedStatement = statement.ToCharArray();

        if (Silence(statement))
        {
            return "Fine. Be that way!";
        }
        
        bool silence = Silence(statement);
        bool isQuestion = IsQuestion(statement);
        bool isUppercase = IsUppercase(articulatedStatement);
       
        if(isUppercase && isQuestion)
        {
            return "Calm down, I know what I'm doing!";
        } else if (isQuestion)
        {
            return "Sure.";
        } else if (isUppercase)
        {
            return "Whoa, chill out!";
        }
        else
        {
            return "Whatever.";
        }

    }


    public static bool IsQuestion(string statement)
    {
        string trimmed = statement.Trim();
        var letters = trimmed.Where(char.IsLetter);
        if (trimmed.Any(char.IsLetter))
        {
            return trimmed[trimmed.Length - 1] == '?' && letters.Any();
        }
        else return true;
    }

    public static bool IsUppercase(char[] statement)
    {
        var letters = statement.Where(char.IsLetter);
        return letters.Any() && letters.All(char.IsUpper);
    }

    public static bool Silence(string statement)
    {
        return statement.Trim().Length == 0;
    }


}