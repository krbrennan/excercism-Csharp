public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        string[] colors = Colors();
        return Array.IndexOf(colors, color);
    }

    public static string[] Colors()
    {
        string[] colors = ["black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"];
        return colors;
    }
}