namespace Project_Catalog.Classes;

public class MyFriday: IMyDateTime
{
    public DateTime GetCurrentDate()
    {
        return new DateTime(2021, 12, 17);
    }
}