static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        //throw new NotImplementedException("Please implement the (static) Badge.Print() method");
        //string dept;
        //if (department == null)
        //{
        //    dept = "Owner";
        //} else { dept = department; }

        string dept = department != null ? department.ToUpper() : "OWNER";
        string stringId = id != null ? ("[" + $"{id.ToString()}" + "] - ") : "";
        //string stringId = $"{id?.ToString() ?? "" }" ;



        return $"{stringId}{name} - {dept}";
    }
}
