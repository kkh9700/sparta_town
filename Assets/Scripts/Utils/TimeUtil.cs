using System;
public class TimeUtil
{
    public string GetCurrentDate()
    {
        return DateTime.Now.ToString(("yyyy-MM-dd HH:mm:ss tt"));
    }

    public string GetCurrentTime()
    {
        return DateTime.Now.ToString(("HH:mm"));
    }

    public string GetYear()
    {
        return DateTime.Now.ToString(("yyyy"));
    }
}