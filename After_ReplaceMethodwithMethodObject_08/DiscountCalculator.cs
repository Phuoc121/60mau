using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_ReplaceMethodwithMethodObject_08
{
    class DiscountCalculator
    {
        public int Discount(int inputVal, int quantity)
        {
            int result = inputVal;

            if (quantity > 50)
            {
                result -= 2;
            }

            return result;
        }
    }

}
