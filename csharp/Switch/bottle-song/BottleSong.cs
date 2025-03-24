public static class BottleSong
{
    public enum Bottles
    {
        Ten = 10,
        Nine = 9,
        Eight = 8,
        Seven = 7,
        Six = 6,
        Five = 5,
        Four = 4,
        Three = 3,
        Two = 2,
        One = 1,
        Zero = 0
    }

    public static string[] Recite(int startBottles, int takeDown)
    {
        int current = takeDown;
        int bottles = startBottles;

        string bottleText = ((Bottles)bottles).ToString();
        string nextBottle = ((Bottles)bottles - 1).ToString().ToLower();
        ((Bottles)bottles).ToString();
        //string[] verse = new string[]
        List<string> verse = new List<string>
            {
            $"{bottleText} green bottles hanging on the wall,",
            $"{bottleText} green bottles hanging on the wall,",
            $"And if one green bottle should accidentally fall,",
            $"There'll be {nextBottle} green bottles hanging on the wall."
            };

        //var expected = new List<string>()[
        //    "Ten green bottles hanging on the wall,",
        //    "Ten green bottles hanging on the wall,",
        //    "And if one green bottle should accidentally fall,",
        //    "There'll be nine green bottles hanging on the wall."
        //];


        List<string> solution = [];

        for (int i = 0; i < takeDown; i++)
        {
            solution.Add(verse[0]);
            solution.Add(verse[1]);
            solution.Add(verse[2]);
            solution.Add(verse[3]);

            if(takeDown > 1 && i < takeDown)
            {
                int TempnextBottleText = bottles - 2;
                int TempnextNextBottle = bottles - 3;
                string tempBottleText = ((Bottles)TempnextBottleText).ToString();
                string tempNextBottle = ((Bottles)TempnextNextBottle).ToString().ToLower();
                solution.Add("");
                var verse = new List<string>
                    {
                    $"{tempBottleText} green bottles hanging on the wall,",
                        $"{tempBottleText} green bottles hanging on the wall,",
                        $"And if one green bottle should accidentally fall,",
                        $"There'll be {tempNextBottle} green bottles hanging on the wall."
                    };
            }

            bottles = bottles--;
            //solution.AddRange(verse);

        }
        return solution.ToArray();
        //return string.Join("\n", solution);
        //return expected.ToList();
    }
}