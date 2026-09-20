namespace Foods;

public class Pizza : IFood
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Pizza");
    }
}