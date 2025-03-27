public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        List<string> solution = [];
        bool terminated = false;

        for (int i = 0; i < strand.Length; i+=3)
        {
            if (terminated)
            {
                return solution.ToArray();
            }
            string currentCodon;
            if (strand.Length == 3)
            {
                currentCodon = strand;
            }
            else
            {
                currentCodon = strand.Substring(i, 3);
            }

            switch (currentCodon)
            {
                case "AUG":
                    solution.Add("Methionine");
                    break;
                case "UUU":
                case "UUC":
                    solution.Add("Phenylalanine");
                    break;
                case "UUA":
                case "UUG":
                    solution.Add("Leucine");
                    break;
                case "UCU":
                case "UCC":
                case "UCA":
                case "UCG":
                    solution.Add("Serine");
                    break;
                case "UAU":
                case "UAC":
                    solution.Add("Tyrosine");
                    break;
                case "UGU":
                case "UGC":
                    solution.Add("Cysteine");
                    break;
                case "UGG":
                    solution.Add("Tryptophan");
                    break;
                case "UAA":
                case "UAG":
                case "UGA":
                    terminated = true;
                    break;
                default:
                    solution.Add("");
                    break;
            }
        }
        return solution.ToArray();
    }

}