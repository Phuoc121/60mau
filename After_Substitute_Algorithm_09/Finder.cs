using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_Substitute_Algorithm_09
{
    class Finder
    {
        // ✅ Solution: gom tất cả tên vào danh sách candidates
        public string FoundPerson(string[] people)
        {
            List<string> candidates = new List<string> { "Don", "John", "Kent" };

            foreach (string person in people)
            {
                if (candidates.Contains(person))
                {
                    return person;
                }
            }

            return "";
        }
    }
}
