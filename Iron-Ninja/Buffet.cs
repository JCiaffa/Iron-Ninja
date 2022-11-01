class Buffet
{
    public List<Food> Menu;
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Taco", 300, true, false),
            new Food("Burger", 700, true, false),
            new Food("Ice Cream", 500, false, false),
            new Food("Yogurt", 20, false, true),
            new Food("Coffee", 50, false, false),
            new Food("Smoothie", 350, false, true),
            new Food("Rice", 300, false, false)
        };
    }
    
    public Food Serve()
    {
        Random rand = new Random();
        return Menu[rand.Next(Menu.Count)];
    }
}