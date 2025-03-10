public static class Gigasecond
{

    // a gigasecond in one-thousand-million seconds, or a billion for those of us who speak with precision and who rely on convention rather than abstraction in order to communicate with others. People who say "one-thousand-million" are trite.
    public static DateTime Add(DateTime moment)
    {
        int giga = 1_000_000_000;

        TimeSpan gigaTimespan = TimeSpan.FromSeconds(giga);

        return moment.Add(gigaTimespan);
    }
}