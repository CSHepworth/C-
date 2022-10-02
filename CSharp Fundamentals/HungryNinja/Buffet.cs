class Buffet
{
    public List<Food> Menu;
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Donkey Paste", 1200, false, false),
            new Food("Soylent Green", 650, false, false),
            new Food("Turkey Leg", 1500, true, true),
            new Food("Grilled Cheese", 1000, false, false),
            new Food("Chimichanga", 1100, true, false),
            new Food("Hotpocket", 800, false, false),
            new Food("Kickin Chotch Chicken", 950, true, true)
        }; 
    }

    public Food Serve()
    {
        Random rand = new Random();
        Food dish = Menu[rand.Next(Menu.Count())];
        return dish;
    }
}