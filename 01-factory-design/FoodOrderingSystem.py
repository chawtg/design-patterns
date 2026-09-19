"""
Factory Design Pattern Example
--------------------------------

The Factory Design Pattern is a creational design pattern that provides
a way to create objects without directly specifying which class should
be instantiated.

In this example:
- Pizza, Burger, and Pasta are different food classes.
- FoodFactory is responsible for creating the correct food object.
- FoodOrderingSystem uses the factory to create and prepare food.
- The ordering system does not need to directly create Pizza, Burger,
  or Pasta objects.

The main benefit is that object creation is separated from the code
that uses the objects. This makes the program easier to maintain and
extend when new food types are added.
"""


class Pizza:
    def prepare(self):
        print("Preparing pizza...")


class Burger:
    def prepare(self):
        print("Preparing burger...")


class Pasta:
    def prepare(self):
        print("Preparing pasta...")


# Create a factory class to create food items
class FoodFactory:
    @staticmethod
    def create_food(food_type):
        if food_type == "pizza":
            return Pizza()
        elif food_type == "burger":
            return Burger()
        elif food_type == "pasta":
            return Pasta()
        else:
            raise ValueError("Invalid food type")


class FoodOrderingSystem:
    def __init__(self):
        self.factory = FoodFactory()

    def order_food(self, food_type):
        try:
            food_item = self.factory.create_food(food_type)
            food_item.prepare()
        except ValueError as e:
            print(e)


# Create an instance of the FoodOrderingSystem
ordering_system = FoodOrderingSystem()

# Order different food items
ordering_system.order_food("pizza")
ordering_system.order_food("burger")
ordering_system.order_food("pasta")

# Attempt to order an invalid food item
ordering_system.order_food("sushi")