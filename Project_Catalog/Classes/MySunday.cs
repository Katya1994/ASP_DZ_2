namespace Project_Catalog.Classes;

public class MySunday: IMyDateTime
{
    public DateTime GetCurrentDate()
    {
        return new DateTime(2021, 12, 19);
    }
}