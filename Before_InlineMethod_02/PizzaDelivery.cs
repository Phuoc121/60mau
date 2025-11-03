using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before_InlineMethod_02
{

    class PizzaDelivery
    {
        private int numberOfLateDeliveries;

        public PizzaDelivery(int lateDeliveries)
        {
            this.numberOfLateDeliveries = lateDeliveries;
        }

        // Trước khi refactor
        public int GetRating()
        {
            return MoreThanFiveLateDeliveries() ? 2 : 1;
        }

        private bool MoreThanFiveLateDeliveries()
        {
            return numberOfLateDeliveries > 5;
        }
    }

}
