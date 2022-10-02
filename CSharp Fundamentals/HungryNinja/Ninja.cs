class Ninja
{
    private int calorieIntake;
    public List<Food> FoodHistory;

    public Ninja()
    {
        calorieIntake = 0;
        FoodHistory = new List<Food>();
    }

    bool IsFull
    {
        get
        {
            return calorieIntake > 1200;
        }
    }

    public void Eat(Food item)
    {
        if (IsFull == false)
        {
            calorieIntake += item.Calories;
            FoodHistory.Add(item);
            Console.WriteLine($"The ninja knocked down {item.Name}!");
            if (item.IsSpicy)
                Console.WriteLine($"That's a spicy {item.Name}!");
            if (item.IsSweet)
                Console.WriteLine($"That's a sweet {item.Name}");
        }
        else
        {
            Console.WriteLine("Ninja is full.");
        }
    }

}