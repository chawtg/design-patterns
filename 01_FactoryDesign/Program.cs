/*
 * Factory Design Pattern Example
 * --------------------------------
 *
 * The Factory Design Pattern is a creational design pattern that provides
 * a way to create objects without directly specifying which class should
 * be instantiated.
 *
 * In this example:
 * - Pizza, Burger, and Pasta are different food classes.
 * - FoodFactory is responsible for creating the correct food object.
 * - FoodOrderingSystem uses the factory to create and prepare food.
 * - The ordering system does not need to directly create Pizza, Burger,
 *   or Pasta objects.
 *
 * The main benefit is that object creation is separated from the code
 * that uses the objects. This makes the program easier to maintain and
 * extend when new food types are added.
 */
public class Program
{
    public static void Main(String[] args)
    {
        FoodOrderingSystem orderingSystem = new FoodOrderingSystem();
        orderingSystem.OrderFood("pizza");
        orderingSystem.OrderFood("burger");
        orderingSystem.OrderFood("pasta");
        orderingSystem.OrderFood("sushi");

    }
}