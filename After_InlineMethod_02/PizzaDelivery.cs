using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_InlineMethod_02
{
    class PizzaDelivery
    {
        private int numberOfLateDeliveries;

        public PizzaDelivery(int lateDeliveries)
        {
            this.numberOfLateDeliveries = lateDeliveries;
        }

        // Sau khi refactor
        public int GetRating()
        {
            return numberOfLateDeliveries > 5 ? 2 : 1;
        }
    }
}
