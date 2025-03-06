public class Robot
{

    char[] alphabet = Enumerable.Range('A', 26).Select(i => (char)i).ToArray();
    //int[] numbers = Enumerable.Range(0, 10).ToArray();

    private string _name = "";

    public string Name
    {
        get
        {
            if(_name.Length < 1)
            {
                // AA123
                string Name = "";
                // pick a random number between 100 and 999
                int num = new Random().Next(100, 999);
                do
                {
                    Name += alphabet[new Random().Next(0, 26)];
                } while (Name.Length < 2);

                Name += num.ToString();
                _name = Name;
                return Name;
            }
            return _name;
            
        }
    }

    public void Reset()
    {
        _name = "";
    }
}