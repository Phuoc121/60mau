using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_HideDelegate
{
    public class Person
    {
        private Department department;

        public Person(Department department)
        {
            this.department = department;
        }

        // Ẩn ủy quyền
        public string GetManager()
        {
            return department.GetManager();
        }
    }
}
