using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplemantationOfIEnumrable
{
    public class CourseMemberList : IEnumerable<CourseMember>
    {
        private List<CourseMember> _courseMembers = new List<CourseMember>();

        public void Add(CourseMember courseMember)
        {
            _courseMembers.Add(courseMember);
        }

        public IEnumerator<CourseMember> GetEnumerator()
        {
            return new CourseMemberEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public CourseMember this[int idx] => _courseMembers[idx];

        public int Count => _courseMembers.Count;

        //public int Count()
        //{
        //    return _courseMembers.Count;
        //}
    }
}
