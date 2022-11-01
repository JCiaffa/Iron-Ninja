class Spicehound : Ninja
{
    public override bool IsFull
    {
        get
        {
        if(calorieIntake >= 1200)
            {
                return false;
            }
            return true;
        }
    }
    public override void Consume(IConsumable item)
    {
        if(IsFull == true){}
        else
        {
            ConsumptionHistory.Add(item);
            calorieIntake -= item.Calories;

            if(item.IsSpicy)
            {
                calorieIntake += 5;
            }
            Console.WriteLine(item.GetInfo());
            Console.WriteLine(calorieIntake);
        }
    }
}