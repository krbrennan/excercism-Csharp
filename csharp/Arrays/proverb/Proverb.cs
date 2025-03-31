public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        List<string> solution = [];

        string finalLine = "And all for the want of a ";


        if (subjects.Length == 0)
        {
            return solution.ToArray();
        } else if(subjects.Length == 1)
        {
            solution.Add(finalLine + subjects[0] + ".");
            return solution.ToArray();
        } else
        {
            for (int i = 0; i < subjects.Length; i++)
            {
                if(i == subjects.Length-1) // if we're at the last item, add in the final line
                {
                    solution.Add(finalLine + subjects[0] + ".");
                    break;
                } else
                {
                    solution.Add($"For want of a {subjects[i]} the {subjects[i + 1]} was lost.");
                }
            }
        }



            return solution.ToArray();



    }
}