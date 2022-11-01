class SweetTooth : Ninja
{
    public override bool IsFull
    {
        get
        {
        if(calorieIntake >= 1500)
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

            if(item.IsSweet)
            {
                calorieIntake += 10;
            }
            Console.WriteLine(item.GetInfo());
            Console.WriteLine(calorieIntake);
        }
    }
}