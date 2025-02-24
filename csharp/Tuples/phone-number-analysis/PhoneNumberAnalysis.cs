using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        //throw new NotImplementedException($"Please implement the (static) PhoneNumber.Analyze() method");
        string[] parts = phoneNumber.Split("-");
        bool isNewYork = (parts[0] == "212" ? true : false);
        bool isFake = (parts[1] == "555" ? true : false);

        return (isNewYork, isFake, parts[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        //throw new NotImplementedException($"Please implement the (static) PhoneNumber.IsFake() method");

        return phoneNumberInfo.IsFake;
        

    }
}
