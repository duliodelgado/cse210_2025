// Made by Dulio Delgado
// Fraction.cs – shows Encapsulation
// private data     (_top, _bottom)
// public methods    (getters / setters / helpers)

using System;

public class Fraction
{
    // other classes cannot touch these directly
    private int _top;
    private int _bottom;

    // --- 3 CONSTRUCTORS --------------------------------------------------

    // 1) No numbers → default fraction is 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // 2) Just the top number → bottom becomes 1   (e.g., 5 → 5/1)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // 3) Both numbers → user gives top AND bottom (e.g., 3, 4 → 3/4)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // --- GETTERS  (read values) ------------------------------------------

    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    // --- SETTERS  (change values) ----------------------------------------

    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // --- HELPER METHODS  --------------------------------------------------

    
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

 
    public double GetDecimalValue()
    {
   
        return (double)_top / _bottom;
    }
}