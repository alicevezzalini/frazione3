using System;

namespace frazione3

{
    public class Fraction
    {
        public int N { get; }
        public int D { get; }

        public Fraction(int n, int d)
        {
            Semplifica(ref n, ref d);

            N = n;
            D = d;
        }

        private void Semplifica(ref int n, ref int d)
        {
            int mcd = CalcolaMcd(n, d);
            n = n / mcd;
            d = d / mcd;
        }

        private int CalcolaMcd(int a, int b)
        {
            while (b != 0)
            {
                int resto = a % b;
                a = b;
                b = resto;
            }
            return a;
        }

        public static Fraction operator+(Fraction a,Fraction other)
        {
            return new Fraction(a.N * other.D + a.D * other.N, a.D * other.D);
        }

        public static Fraction operator-(Fraction a, Fraction other)
        {
            return new Fraction(a.N * other.D - a.D * other.N, a.D * other.D);
        }

        public static Fraction operator*(Fraction a, Fraction other)
        {
            return new Fraction(a.N * other.N, a.D * other.D);
        }

        public static Fraction operator/(Fraction a, Fraction other)
        {
            return new Fraction(a.N * other.D, a.D * other.N);
        }
        
        public static Fraction operator-(Fraction a)
        {
            return new Fraction(-a.N, a.D);
        }


        public override string ToString()
        {
            return $"{N}/{D}";
        }


        public static Fraction Parse(string s)
        {
            string[] parts = s.Split('/');
            return new Fraction(int.Parse(parts[0]), int.Parse(parts[1]));
        }
    }
}
