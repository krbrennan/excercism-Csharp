static class Appointment
{

    // Three date formats will be given/used:
    //"7/25/2019 13:45:00"
    //"July 25, 2019 13:45:00"
    //"Thursday, July 25, 2019 13:45:00"

    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription);
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        return appointmentDate < DateTime.Now;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        //return int.Parse(appointmentDate.ToString("HH")) > 12;
        int hour = appointmentDate.Hour;
        return hour >= 12 && hour < 18;
    }

    public static string Description(DateTime appointmentDate)
    {
        //DateTime pretty = appointmentDate.Date;
        //int hour = appointmentDate.Hour;
        //string AmPm = appointmentDate.Hour < 12 ? "AM" : "PM";
        return $"You have an appointment on {appointmentDate.ToString("d")} {appointmentDate.ToString("h:mm:ss tt")}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15);
    }
}
