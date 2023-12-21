using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LB_V8
{
    public class WorkerContainer<T> : IEnumerable<T> where T : Human //ICollection<T>
    {
        #region Fields
        private readonly LinkedList<T> _container1;
        #endregion
        #region Constructors
        public WorkerContainer()
        {
            _container1 = new LinkedList<T>();
        }
        #endregion
        #region Properties
        public int Count
        {
            get { return _container1.Count; }
        }
        #endregion
        #region Indexers
        public T this[int index]
        {

            get
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException();


                var temp = _container1.First;
                for (int i = 0; i < index; i++)
                {
                    temp = temp.Next;

                }
                return temp.Value;

            }
            set
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException();
                var temp = _container1.First;
                for (int i = 0; i < index; i++)
                {
                    temp = temp.Next;

                }
                var currentElement = temp;
                currentElement.Value = value;
            }

        }
        #endregion
        #region Methods
        public T GetByName(string name)
        {
            return
                _container1.FirstOrDefault(
                    h => string.Compare(h.FirstName, name,
                             StringComparison.InvariantCultureIgnoreCase) == 0);
        }
        // public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T human)
        {
            //_container1.AddFirst(human);
            _container1.AddLast(human);
            //throw new NotImplementedException();
        }

        public void Clear()
        {

            _container1.Clear();
        }

        public bool Contains(T item)
        {
           return _container1.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _container1.CopyTo(array, arrayIndex);
        }

        public bool Remove(T human)
        {
            _container1.Remove(human);
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            
            return _container1.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            
            return ((IEnumerable<T>)this).GetEnumerator();
            throw new NotImplementedException();
        }
        #endregion
    }
}

