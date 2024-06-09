namespace Task_2;

public abstract class Device
{
    public string Model { get; set; }
    public string Description { get; set; }

    public abstract void Sound();
    public abstract void Show();
    public abstract void Desc();

    public Device(string model, string desc)
    {
        Model = model;
        Description = desc;
    }
}