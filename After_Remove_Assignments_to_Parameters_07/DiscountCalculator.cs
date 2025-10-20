using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_Remove_Assignments_to_Parameters_07
{
    class DiscountCalculator
    {
        public int Discount(int inputVal, int quantity)
        {
            if (quantity > 50)
            {
                inputVal -= 2;
            }

            // Có thể còn các bước khác
            return inputVal;
        }
    }
}
