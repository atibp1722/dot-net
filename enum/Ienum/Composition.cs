using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ienum
{
    class Composition<T> : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator() 
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator() 
        {
            throw new NotImplementedException ();
        }
    }
}
