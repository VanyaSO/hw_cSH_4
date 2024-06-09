namespace Task_2;

public class Kettle: Device
{
    public int Watt { get; set; }

    public Kettle(string model, string desc, int watt) : base(model, desc)
    {
        Watt = watt;
    }

    public override void Sound()
    {
        Console.WriteLine("Чайник всистит");
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