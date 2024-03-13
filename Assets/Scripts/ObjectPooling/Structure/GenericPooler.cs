using System;
using System.Collections.Generic;

namespace ObjectPooling.Structure
{
    
    // class able to manage any poolable object
    public class GenericPooler<T> where T: class, IPoolableObject, new()
    {
        #region Constructor

        // Consructor, you must have to specify the starting size of the pool
        public GenericPooler(int startSize)
        {
            StartSize = startSize;

            for (var i  = 0;  i < StartSize; i++)
            {
                var obj = new T();
                freeObjects.Add(obj);

            }
        }

        #endregion

        #region Fields

        readonly List<T> busyObjects = new List<T>();
        readonly List<T> freeObjects = new List<T>();

        #endregion

        #region Properties

        public int StartSize { get; }
        public int SizeFreeObjects => freeObjects.Count;
        public int SizeBusyObjects => busyObjects.Count;
        public Type PoolType => typeof(T);

        #endregion

        #region Methods

        // Get an object of the type T
        public T Get()
        {
            T pooled = null;
            
            if (SizeFreeObjects > 0)
            {
                // pool the last object
                pooled = freeObjects[SizeFreeObjects - 1];
                freeObjects.Remove(pooled);
            }
            else
            {
                // if cant pool create new object
                pooled = new T();
            }
            
            busyObjects.Add(pooled);
            
            return pooled;
        }
        
        // release the object of the type T
        public void Release(T released)
        {
            if(released == null)
                throw new ArgumentNullException(nameof(released), "The released object is null");
            
            //reset the object
            released.Restart();
            
            // add backt to the freelist
            freeObjects.Add(released);
            
            // remove from busy list
            busyObjects.Remove(released);
        }

        #endregion
    }
}