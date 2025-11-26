using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_interface
{
    internal class MyComplex : IMyNumber<MyComplex>
    {
        public MyComplex Add(MyComplex b)
        {
            throw new NotImplementedException();
        }

        public MyComplex Divide(MyComplex b)
        {
            throw new NotImplementedException();
        }

        public MyComplex Multiply(MyComplex b)
        {
            throw new NotImplementedException();
        }

        public MyComplex Subtract(MyComplex b)
        {
            throw new NotImplementedException();
        }
    }
}
