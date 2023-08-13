using System;

namespace WindowsFormsApp2
{
    class Fraction
    {
        private int denumerator;
        public int Numerator { get; set; }
        public int Denomerator
        {
            get
            {
                return denumerator;
            }
            set
            {
                if (value == 0) throw new DivideByZeroException();
                denumerator = value != 0 ? value : denumerator;
            }
        }

        public Fraction(int numerator, int denomerator)
        {
            Numerator = numerator;
            Denomerator = denomerator;
        }

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            return new Fraction(fraction1.Numerator * fraction2.Denomerator + fraction2.Numerator * fraction1.Denomerator,
                                fraction1.Denomerator * fraction2.Denomerator);
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            return new Fraction(fraction1.Numerator* fraction2.Denomerator - fraction2.Numerator * fraction1.Denomerator,
                                fraction1.Denomerator* fraction2.Denomerator);
        }

        public static Fraction operator *(Fraction fraction1, Fraction fraction2)
        {
            return new Fraction(fraction1.Numerator * fraction2.Numerator, fraction1.Denomerator * fraction2.Denomerator);
        }

        public static Fraction operator /(Fraction fraction1, Fraction fraction2)
        {
            return new Fraction(fraction1.Numerator * fraction2.Denomerator, fraction1.Denomerator * fraction2.Numerator);
        }

        public static bool operator >(Fraction fraction1, Fraction fraction2)
        {
            return fraction1.Numerator * fraction2.Denomerator > fraction2.Numerator * fraction1.Denomerator ? true : false;
        }

        public static bool operator <(Fraction fraction1, Fraction fraction2)
        {
            return fraction1.Numerator * fraction2.Denomerator < fraction2.Numerator * fraction1.Denomerator ? true : false;
        }

        public static bool operator >=(Fraction fraction1, Fraction fraction2)
        {
            return fraction1.Numerator * fraction2.Denomerator >= fraction2.Numerator * fraction1.Denomerator ? true : false;
        }

        public static bool operator <=(Fraction fraction1, Fraction fraction2)
        {
            return fraction1.Numerator * fraction2.Denomerator <= fraction2.Numerator * fraction1.Denomerator ? true : false;
        }

        public static bool operator ==(Fraction fraction1, Fraction fraction2)
        {
            return fraction1.Numerator * fraction2.Denomerator == fraction2.Numerator * fraction1.Denomerator ? true : false;
        }

        public static bool operator !=(Fraction fraction1, Fraction fraction2)
        {
            return fraction1.Numerator * fraction2.Denomerator != fraction2.Numerator * fraction1.Denomerator ? true : false;
        }

        public Fraction Reduce()
        {
            int nod = Nod(Numerator, Denomerator);
            if (nod != 0)
            {
                Numerator /= nod;
                Denomerator /= nod;
            }
            return this;
        }

        private int Nod(int numerator, int denomerator)
        {
            int temp;
            numerator = Math.Abs(numerator);
            denomerator = Math.Abs(denomerator);
            while (denomerator != 0 && numerator != 0)
            {
                if (numerator % denomerator > 0)
                {
                    temp = numerator;
                    numerator = denomerator;
                    denomerator = temp % denomerator;
                }
                else break;
            }
            if (denomerator != 0 && numerator != 0) return denomerator;
            else return 0;
        }

        public override string ToString()
        {
            Reduce();
            if (Denomerator == 1 || Numerator == 0) return Numerator + "";
            return Numerator + "/" + Denomerator;
        }
    }
}
