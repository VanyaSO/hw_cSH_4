namespace Task_2;

public class Car: Device
{
    public double MotorVolume { get; set; }

    public Car(string model, string desc, double motorVolume) : base(model, desc)
    {
        MotorVolume = motorVolume;
    }

    public override void Sound()
    {
        Console.WriteLine("Машина едет");
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