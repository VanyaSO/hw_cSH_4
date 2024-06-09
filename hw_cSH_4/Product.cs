namespace hw_cSH_4;

public class Product: Money
{
    public string Name { get; set; }
    
    public Product():base(){}
    public Product(string name,  double price, string currency) : base(price, currency)
    {
        Name = name;
    }

    public void ReducePrice(double reducePrice)
    {
        if (reducePrice <= 0)
            throw new ArgumentException("Ошибка: значение <= 0");

        if (WholePart + Panny - reducePrice < 0)
            throw new ArgumentException($"Ошибка: значение < {reducePrice}");
        
        DivisionIntoParts(WholePart + Panny - reducePrice);
    }

    public override string ToString()
    {
        return $"{Name}: {WholePart+Panny} {Currency}";
    }
}