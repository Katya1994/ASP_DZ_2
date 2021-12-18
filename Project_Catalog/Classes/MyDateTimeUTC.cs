namespace Project_Catalog.Classes;

public class MyDateTimeUTC: IMyDateTime
{
    public DateTime GetCurrentDate()
    {
        return DateTime.UtcNow;
    }
}