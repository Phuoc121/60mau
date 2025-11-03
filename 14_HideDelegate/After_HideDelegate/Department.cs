using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_HideDelegate
{
    public class Department
    {
        private string manager;

        public Department(string manager)
        {
            this.manager = manager;
        }

        public string GetManager()
        {
            return manager;
        }
    }
}
