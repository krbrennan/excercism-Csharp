public class Robot
{


    public static readonly HashSet<string> AllRobots = new HashSet<string>(); 

    private string _name = "";

    public string Name
    {
        get
        {
            if(_name == "") { Reset(); }
            return _name;

        }
    }



    public void Reset()
    {
        char[] alphabet = Enumerable.Range('A', 26).Select(i => (char)i).ToArray();
        string TempName = "";
        int num = new Random().Next(100, 999);
        TempName += alphabet[new Random().Next(0, 26)];
        TempName += alphabet[new Random().Next(0, 26)];
        TempName += num.ToString();
        if(!AllRobots.Add(TempName)) {
            Reset(); 
        } else
        {
            _name = TempName;
            AllRobots.Add(TempName);
        }
    }
}