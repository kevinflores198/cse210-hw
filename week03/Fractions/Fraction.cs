public class Fraction
{
    private double _topNumber;
    private double _bottonNumber;
    public double GetTopNumber()
    {
        return _topNumber;
    }
    public void SetTopNumber(int topNumber)
    {
        _topNumber = topNumber;
    }
    public double GetBottonNumber()
    {
        return _bottonNumber;
    }
    public void SetBottonNumber(int bottonNumber)
    {
        _bottonNumber = bottonNumber;
    }
    // first constructor with no parameter, will return those numbers defined into that.
    public Fraction()
    {
        _topNumber = 1;
        _bottonNumber = 1;
    }
    // second constructor will return both numbers, but it has one parameter with a variable to define.
    public Fraction(int wholeNumber)
    {
        _topNumber = wholeNumber;
        _bottonNumber = 1;
    }
    // third constructor will return two numbers, both parameters to define when it will be called..
    public Fraction(int topNumber, int bottonNumber)
    {
        _topNumber = topNumber;
        _bottonNumber = bottonNumber;
    }
    // method used to get string of both number one above the other as a fraction.
    public string GetFractionString()
    {
        string string_Fraction = $"{_topNumber}/{_bottonNumber}";
        return string_Fraction;
    }
    // method that get the decimal value of the string fraction made before. Double allows to get number with decimals.
    public double GetDecimalValue()
    {
        return _topNumber / _bottonNumber;
    }
}