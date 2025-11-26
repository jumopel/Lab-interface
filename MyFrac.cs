using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_interface
{
    internal class MyFrac : IMyNumber<MyFrac>
    {
        public MyFrac Add(MyFrac b)
        {
            throw new NotImplementedException();
        }

        public MyFrac Divide(MyFrac b)
        {
            throw new NotImplementedException();
        }

        public MyFrac Multiply(MyFrac b)
        {
            throw new NotImplementedException();
        }

        public MyFrac Subtract(MyFrac b)
        {
            throw new NotImplementedException();
        }
    }
}
