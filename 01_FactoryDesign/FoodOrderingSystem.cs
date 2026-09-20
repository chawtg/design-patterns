using Foods;
public class FoodOrderingSystem
{
    private readonly FoodFactory _foodFactory = new FoodFactory();

    public void OrderFood(String foodType)
    {
        try
        {
            IFood foodItem = _foodFactory.CreateFood(foodType);
            foodItem.Prepare();

        }
        catch (ArgumentException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }

}