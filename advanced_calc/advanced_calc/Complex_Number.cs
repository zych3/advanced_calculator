namespace advanced_calc;

public class ComplexNumber
{
    public ComplexNumber(int re, int im)
    {
        Re = re;
        Im = im;
    }

    public override string ToString()
    {
        return (Re + " + " + Im + "i");
    }

    public static bool operator ==(ComplexNumber n, ComplexNumber z)
    {
        return n.Re == z.Re && n.Im == z.Im;
    }

    public static bool operator !=(ComplexNumber n, ComplexNumber z)
    {
        return !(n == z);
    }

    public static ComplexNumber operator +(ComplexNumber n, ComplexNumber z)
    {
        return new ComplexNumber(n.Re + z.Re, n.Im + z.Im);
    }
    
    public static ComplexNumber operator -(ComplexNumber n, ComplexNumber z)
    {
        return new ComplexNumber(n.Re - z.Re, n.Im - z.Im);
    }
    
    public static ComplexNumber operator *(ComplexNumber n, ComplexNumber z)
    {
        return new ComplexNumber(n.Re * z.Re, n.Im * z.Im);
    }
    
    public static ComplexNumber operator /(ComplexNumber n, ComplexNumber z)
    {
        return new ComplexNumber(n.Re / z.Re, n.Im / z.Im);
    }

    public static ComplexNumber operator !(ComplexNumber n)
    {
        return new ComplexNumber(-(n.Re), -(n.Im));
    }

    public int Re { get; }
    public int Im { get; }
}