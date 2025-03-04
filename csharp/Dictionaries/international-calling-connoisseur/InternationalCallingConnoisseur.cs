public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        return new Dictionary<int, string> { };
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        return new Dictionary<int, string>
        {
            { 1, "United States of America"},
            { 55, "Brazil" },
            { 91, "India" }
        };
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        var tempEmptyDict = GetEmptyDictionary();
            tempEmptyDict.Add(countryCode, countryName);
        return tempEmptyDict;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        var tempEmptyDict = GetExistingDictionary();
        tempEmptyDict.Add(countryCode, countryName);
        return tempEmptyDict;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (!existingDictionary.ContainsKey(countryCode))
        {
            return "";
        }
        return existingDictionary[countryCode];
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.Keys.Contains(countryCode);
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if(!existingDictionary.ContainsKey(countryCode))
        {
            return existingDictionary;
        }
        var tempEmptyDict = GetExistingDictionary();
        tempEmptyDict[countryCode] = countryName;
        return tempEmptyDict;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        var tempEmptyDict = GetExistingDictionary();
        tempEmptyDict.Remove(countryCode);
        return tempEmptyDict;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        //var allCountries = existingDictionary.Values;
        if(existingDictionary.Keys.Count == 0)
        {
            return "";
        }
        return existingDictionary.Values.OrderByDescending(country => country.Length).First();


    }
}