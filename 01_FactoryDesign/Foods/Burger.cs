namespace Foods;

public class Burger : IFood
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Burger");
    }
}