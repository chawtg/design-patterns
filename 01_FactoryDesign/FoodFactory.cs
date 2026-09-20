using Foods;
public class FoodFactory
{
    public IFood CreateFood(String foodType)
    {
        switch (foodType)
        {
            case "pizza":
                return new Pizza();
            case "burger":
                return new Burger();
            case "pasta":
                return new Pasta();
            default:
                throw new ArgumentException("Invalid Food Type");
        }
    }
}