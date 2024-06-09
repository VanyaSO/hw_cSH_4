namespace Task_2;

public class Microwave: Device
{
    public int VolumeL { get; set; }

    public Microwave(string model, string desc, int volumeL) : base(model, desc)
    {
        VolumeL = volumeL;
    }

    public override void Sound()
    {
        Console.WriteLine("Микровалновка греет");
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