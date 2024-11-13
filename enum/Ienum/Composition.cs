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
        private List <IEnumerable<T>> collections;

        //constructor
        public Composition(IEnumerable<IEnumerable<T>> collections)
        {
            collections=collections.ToList();
        }

        public Composition() 
        {
            collections = new List<IEnumerable<T>>();
        }

        public void Add (IEnumerable<T> collectio)
        {
            collections.Add(collectio);
        }
        
        public IEnumerator<T> GetEnumerator() 
        {
            foreach(var collection in collections)
            {
                foreach(var item in collection)
                {
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() 
        {
            return GetEnumerator();
        }
    }
}
