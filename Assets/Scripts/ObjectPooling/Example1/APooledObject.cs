using ObjectPooling.Structure;
using UnityEngine;

namespace ObjectPooling.Example1
{
    public class APooledObject : IPoolableObject
    {
        public void Restart() => Debug.Log(GetType() + " Pooled back");

    }
}