public class Shapes
{
    private string _color;


    public Shapes(string color)
    {
        _color = color;
    }


    public virtual string GetColor()
    {
        return _color;
    }
    public virtual void SetColor(string color)
    {
        _color = color;
    }
    public virtual double GetArea()
    {
        return 0;
    }




}