
Buffet buffet = new Buffet();
SweetTooth Jason = new SweetTooth();
Spicehound Tanner = new Spicehound();

Console.WriteLine("Jason is eating");
while (Jason.IsFull != true)
{
    Jason.Consume(buffet.Serve());
}
Console.WriteLine("Jason is full");

Console.WriteLine("Tanner is eating");
while (Tanner.IsFull != true)
{
    Tanner.Consume(buffet.Serve());
}
Console.WriteLine("Tanner is full");