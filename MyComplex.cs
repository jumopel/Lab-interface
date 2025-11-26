using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_interface
{
    internal class MyComplex : IMyNumber<MyComplex>
    {
        public double Real { get; }
        public double Imag { get; }
        public MyComplex(double real, double imag)
        {
            Real = real;
            Imag = imag;
        }
        public MyComplex Add(MyComplex b)
        {
        return new MyComplex(Real + b.Real, Imag + b.Imag);
        }

        public MyComplex Divide(MyComplex b)
        {
            double d = b.Real * b.Real + b.Imag * b.Imag;
            if (d == 0) throw new DivideByZeroException();

            return new MyComplex(
                (Real * b.Real + Imag * b.Imag) / d,
                (Imag * b.Real - Real * b.Imag) / d);
        }

        public MyComplex Multiply(MyComplex b)
        {
            return new MyComplex(
            Real * b.Real - Imag * b.Imag,
            Real * b.Imag + Imag * b.Real);
        }

        public MyComplex Subtract(MyComplex b)
        {
            return new MyComplex(Real - b.Real, Imag - b.Imag);
        }
    }
}
