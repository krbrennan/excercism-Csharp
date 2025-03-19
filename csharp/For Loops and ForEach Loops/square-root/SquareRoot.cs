using System.Reflection.Metadata.Ecma335;

public static class SquareRoot
{
    public static int Root(int number)
    {
        int solution = 1;
        // first iteration will try the obvious for loop approach
        for (int i = 1; i < number; i++)
        {
            if(i * i == number)
            {
                solution = i;
                return solution;
            } else
            {
                continue;
            }
            
        }
        return solution;
    }
}
