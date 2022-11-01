abstract class Ninja
{
    public int calorieIntake;
    public List<IConsumable> ConsumptionHistory;
    public Ninja()
    {
        calorieIntake = 3500;
        ConsumptionHistory = new List<IConsumable>();
    }
    public abstract bool IsFull {get;}
    public abstract void Consume(IConsumable item);
}