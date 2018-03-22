using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibrary
{
    public class MathsOperations : IMathsOperations
    {
        public int Add(int num1, int num2)
        {
            return (num1 + num2);
        }
        public int Multiply(int num1, int num2)
        {
            return (num1 * num2);
        }

        public int Divide(int num1, int num2)
        {
            CustomFaultDetails ex = new CustomFaultDetails("Dividing by 0 is forbidden");

            if (num2 == 0)
            {
                throw new FaultException<CustomFaultDetails>(ex, new FaultReason(ex.Message));
            }
            return (num1 / num2);
        }
    }
}
