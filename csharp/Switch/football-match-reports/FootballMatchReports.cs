
public static class PlayAnalyzer
{

    //this wasn't needed because the final default condition of a swich handles it
    //public static bool IsNumberValue(int num)
    //{
    //    return num > 11;
    //}
    public static string AnalyzeOnField(int shirtNum)
    {
        //if(!IsNumberValue(shirtNum))
        //{
        //    return "";
        //}

        switch (shirtNum)
        {
            case 1:
                return "goalie";
                break;
            case 2:
                return "left back";
            case int i when i == 3 || i == 4:
                return "center back";
            case 5:
                return "right back";
            case int i when i == 6 || i == 7 || i == 8:
                return "midfielder";
            case 9:
                return "left wing";
            case 10:
                return "striker";
            case 11:
                return "right wing";
            default:
                return "UNKNOWN";
        }
    }

    public static string AnalyzeOffField(object report)
    {

        switch (report)
        {
            case int i:
                return $"There are {i} supporters at the match.";
                break;
            case string s:
                return s;
                break;
            case Foul f:
                return f.GetDescription();
                break;
            case Injury j:
                return $"Oh no! {j.GetDescription()} Medics are on the field.";
            case Incident inc:
                return inc.GetDescription();
            case Manager mg:
                // check if manager has a team and return appropriately
                if(mg.Club == null)
                {
                    return mg.Name;
                } else
                {
                    return $"{mg.Name} ({mg.Club})";
                }
                    default:
                return "";
                break;
        }
    }
}
