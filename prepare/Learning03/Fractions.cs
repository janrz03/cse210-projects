using System;

public class Fraction

{
    private int _bottomNumber = 0;
    private int _topNumber = 1;

    public Fraction () 
    {
        _bottomNumber = 1;
        _topNumber = 1;

    }

    public Fraction(int DenomNumber) 
    {
        _topNumber = DenomNumber;
        _bottomNumber = 1;

    }

    public Fraction (int topNumber, int bottomNumber) 
    {
        _bottomNumber = bottomNumber;
        _topNumber = topNumber;

    }

    public string GetFractionString()
    {
        string output = $"{_topNumber}/{_bottomNumber}";
        return output;
    }

    public double GetDecimalValue()
    {
        return (double)_topNumber / (double)_bottomNumber;
    }

}