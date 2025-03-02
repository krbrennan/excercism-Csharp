public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        //throw new NotImplementedException("You need to implement this method.");

        // Year must be divisible by 4
        // divisible by 100 means nothing unless also divisible by 400
        // Is it time to use modulo?

        bool isLeap = false;

        if ((year % 100 == 0) && (year % 400 == 0))
        {
            isLeap = true;
        } else if((year % 100 !=0) && (year % 4 == 0))
        {
            isLeap = true;
        } else
        {
            return isLeap;
        }
        return isLeap;
    }
}