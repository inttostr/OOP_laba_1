using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    public class Rational
    {
        private readonly int _numerator;
        private readonly int _denominator;

        public int Numerator => _numerator;
        public int Denominator => _denominator;

        public Rational(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be zero.");

            int gcd = GCD(numerator, denominator);
            _numerator = numerator / gcd;
            _denominator = denominator / gcd;

            if (_denominator < 0)
            {
                _numerator = -_numerator;
                _denominator = -_denominator;
            }
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }

        public static Rational operator +(Rational a, Rational b)
        {
            int newNumerator = a._numerator * b._denominator + b._numerator * a._denominator;
            int newDenominator = a._denominator * b._denominator;
            return new Rational(newNumerator, newDenominator);
        }

        public static Rational operator -(Rational a, Rational b)
        {
            int newNumerator = a._numerator * b._denominator - b._numerator * a._denominator;
            int newDenominator = a._denominator * b._denominator;
            return new Rational(newNumerator, newDenominator);
        }

        public static Rational operator *(Rational a, Rational b)
        {
            int newNumerator = a._numerator * b._numerator;
            int newDenominator = a._denominator * b._denominator;
            return new Rational(newNumerator, newDenominator);
        }

        public static Rational operator /(Rational a, Rational b)
        {
            int newNumerator = a._numerator * b._denominator;
            int newDenominator = a._denominator * b._numerator;
            return new Rational(newNumerator, newDenominator);
        }

        public static Rational operator -(Rational a)
        {
            return new Rational(-a._numerator, a._denominator);
        }

        public static bool operator ==(Rational a, Rational b)
        {
            return a._numerator == b._numerator && a._denominator == b._denominator;
        }

        public static bool operator !=(Rational a, Rational b)
        {
            return !(a == b);
        }

        public static bool operator <(Rational a, Rational b)
        {
            return a._numerator * b._denominator < b._numerator * a._denominator;
        }

        public static bool operator <=(Rational a, Rational b)
        {
            return a._numerator * b._denominator <= b._numerator * a._denominator;
        }

        public static bool operator >(Rational a, Rational b)
        {
            return a._numerator * b._denominator > b._numerator * a._denominator;
        }

        public static bool operator >=(Rational a, Rational b)
        {
            return a._numerator * b._denominator >= b._numerator * a._denominator;
        }

        private static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
    }


}
