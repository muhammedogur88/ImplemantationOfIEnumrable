using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplemantationOfIEnumrable
{
    public class CourseMemberEnumerator : IEnumerator<CourseMember>
    {
        private CourseMemberList _courseMembersList;
        private int _idx;

        public CourseMemberEnumerator(CourseMemberList courseMembersList)
        {
            _courseMembersList = courseMembersList;
            _idx = -1;
        }

        public CourseMember Current => _courseMembersList[_idx];

        object IEnumerator.Current => Current; // _courseMembersList[_idx]; (Aynı şey)

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return ++_idx < _courseMembersList.Count;
        }

        public void Reset()
        {
            _idx = -1;
        }
    }
}
