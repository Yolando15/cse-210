class Fractions
{
    private int _top;
    private int _bottom;
    public int Divide()
    {
        
        return 1/1;
    }
    public int Divide( int top)
    {
        return top/1;
    }
    public int Divide(int top, int bottom)
    {
        return top/bottom;
    }
    public void SetTop(int num)
    {
        _top=num;
    }
    public void SetBottom(int num)
    {
        _bottom=num;
    }
    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
}