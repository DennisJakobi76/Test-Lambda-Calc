using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Lambda_Calc
{
    internal class Calculator : Operation
    {
        public void performOperation(double x, double y)
        {
            throw new NotImplementedException();
        }

        public void calculate(double x, double y, Action<double, double> operation)
        {
            operation(x, y);
        }
    }
}
