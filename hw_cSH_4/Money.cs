namespace hw_cSH_4;

public class Money
{
    public string Currency { get; set; }
    private int _wholePart;
    public int WholePart 
    {
        get
        {
            return _wholePart;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Ошибка: значение < 0");
            
            _wholePart = value;
        }
    }
    private double _panny;
    public double Panny 
    {
        get
        {
            return _panny;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Ошибка: значение < 0");
            
            _panny = value;
        }
    }
    

    public Money() { }

    public Money(double money, string currency)
    {
        Currency = currency;
        DivisionIntoParts(money);
    }
    
    protected void DivisionIntoParts(double money)
    {
        _wholePart = (int)money;
        _panny = money - _wholePart;
    }
    

    public override string ToString()
    {
        return $"{_wholePart+_panny} {Currency}";
    }
    
}