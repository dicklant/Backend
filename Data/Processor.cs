namespace Backend.Data;

public class Processor
{
    public string getDate()
    {
        return System.DateTime.Now.ToLongDateString();
    }


}