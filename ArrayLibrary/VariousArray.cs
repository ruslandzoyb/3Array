using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibrary
{
    public class VariousArray<T> :IEnumerable<T>,IEnumerator<T>
    {
        private List<T> list = new List<T>();
        int position = -1;

        public T Current { get { return list[position]; } }

        object IEnumerator.Current { get { return list; } }

       public void Add(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
           
            list.Add((T)obj);
          
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (position<list.Capacity-1)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

       
    }
}
