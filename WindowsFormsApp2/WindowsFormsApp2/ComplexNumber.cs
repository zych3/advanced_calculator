using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
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

        public static ComplexNumber operator !(ComplexNumber n)
        {
            return new ComplexNumber(n.Re, -n.Im);
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
            int realPart = n.Re * z.Re - n.Im * z.Im;
            int imaginaryPart = n.Re * z.Im + n.Im * z.Re;

            return new ComplexNumber(realPart, imaginaryPart);
        }
    
        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            int denominator = b.Re * b.Re + b.Im * b.Im;

            int realPart = (a.Re * b.Re + a.Im * b.Im) / denominator;
            int imaginaryPart = (a.Im * b.Re - a.Re * b.Im) / denominator;

            return new ComplexNumber(realPart, imaginaryPart);
        }

        public static ComplexNumber operator -(ComplexNumber n)
        {
            return new ComplexNumber(-(n.Re), -(n.Im));
        }

        public static ComplexNumber FromTextbox(TextBox textBox1, TextBox textBox2)
        {
            int Re, Im;
            if (int.TryParse(textBox1.Text, out Re) && int.TryParse(textBox2.Text, out Im))
            {
                return new ComplexNumber(Re, Im);
            }

            MessageBox.Show("najpierw wprowadź wartości debilu");
            throw new ArgumentException("pola wartości puste zjebie");
        }

        public int Re { get; }
        public int Im { get; }
    }
}