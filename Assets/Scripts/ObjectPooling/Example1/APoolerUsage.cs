using System.Collections.Generic;
using UnityEngine;
using Utils.Attributes;

namespace ObjectPooling.Example1
{
    public class APoolerUsage : MonoBehaviour
    {
        const int START_SIZE = 10;
        readonly List<APooledObject> _objects = new List<APooledObject>();
        private readonly APoolerObject pool = new APoolerObject(START_SIZE);

        [Button]
        void Get()
        {
            var obj = pool.Get();
            _objects.Add(obj);
            Debug.Log("[" + _objects.Count + "]:" + obj.GetType() + " Created ");
        }

        [Button]
        void Release()
        {
            if (_objects.Count < 1) return;

            var index = Random.Range(0, _objects.Count);
            var obj = _objects[index];
            pool.Release(obj);
            _objects.Remove(obj);
            Debug.Log("[" + index + "]:" + obj.GetType() + " Released ");
        }
    }
}