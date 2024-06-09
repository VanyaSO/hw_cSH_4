namespace Task_2;

public class Steamer: Device
{
    public int MaxSpeed { get; set; }

    public Steamer(string model, string desc, int maxSpeed) : base(model, desc)
    {
        MaxSpeed = maxSpeed;
    }

    public override void Sound()
    {
        Console.WriteLine("Пароход плывет");
    }
    
    public override void Show()
    {
        Console.WriteLine(Model);
    }

    public override void Desc()
    {
        Console.WriteLine(Description);
    }
}