public static class ReverseString
{
    public static string Reverse(string input)
    {
        if(input.Length == 0)
        {
            return input;
        }
        return new string(input.Reverse().ToArray());
    }
}