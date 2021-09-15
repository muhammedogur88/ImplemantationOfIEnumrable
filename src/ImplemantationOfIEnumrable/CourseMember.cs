using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplemantationOfIEnumrable
{
    public class CourseMember
    {
        private readonly string _name;
        private readonly string _surName;

        public CourseMember(string name, string surName)
        {
            _name = name;
            _surName = surName;
        }

        public override string ToString()
        {
            return $"Üye: {_name} {_surName}";
        }
    }
}
