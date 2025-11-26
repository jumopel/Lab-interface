using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lab_interface
{
    public class MyFrac : IMyNumber<MyFrac>
    {
        public BigInteger Numerator { get; }
        public BigInteger Denominator { get; }
        public MyFrac(BigInteger num, BigInteger den)
        {
            if (den == 0) throw new DivideByZeroException();
            if (den < 0)
            {
                num = -num;
                den = -den;
            }
            BigInteger g = BigInteger.GreatestCommonDivisor(num, den);
            Numerator = num / g;
            Denominator = den / g;
        }
        public MyFrac(int nom, int denom) : this(new BigInteger(nom), new BigInteger(denom))
        {
        }

        public MyFrac(int nom) : this(new BigInteger(nom), BigInteger.One)
        {
        }

        public MyFrac() : this(BigInteger.Zero, BigInteger.One)
        {
        }

        public MyFrac Add(MyFrac b)
        {
            return new MyFrac(
            Numerator * b.Denominator + b.Numerator * Denominator,
            Denominator * b.Denominator);
        }

        public MyFrac Divide(MyFrac b)
        {
            if (b.Numerator == 0) throw new DivideByZeroException();
            return new MyFrac(
                Numerator * b.Denominator,
                Denominator * b.Numerator
            );
        }

        public MyFrac Multiply(MyFrac b)
        {
            return new MyFrac(
            Numerator * b.Numerator,
            Denominator * b.Denominator);
        }

        public MyFrac Subtract(MyFrac b)
        {
             return new MyFrac(
             Numerator * b.Denominator - b.Numerator * Denominator,
             Denominator * b.Denominator);
        }
        public override string ToString() => $"{Numerator}/{Denominator}";
    }
}
