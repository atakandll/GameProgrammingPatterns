using UnityEngine;
using Utils.Attributes;

namespace ObjectPooling.Example2
{
    public class PrefabPoolUsage : MonoBehaviour
    {
        [Tooltip("The Pooler")] [SerializeField]
        APooler Pooler;
        
        [Tooltip("The Pooled GameObject")] [SerializeField]
        GameObject[] Prefabs;
        
        [Button]
        public void PoolRandomObject()
        {
            var randomIndex = Random.Range(0, Prefabs.Length);
            var randomObj = Prefabs[randomIndex];
            var obj = Pooler.Get<APooled>(randomObj);
            obj.transform.SetParent(transform);
        }
        
        [Button]
        //release random child
        public void ReleaseRandomChild()
        {
            if (transform.childCount <= 0)
                return;

            var randomIndex = Random.Range(0, transform.childCount);
            var randomChild = transform.GetChild(randomIndex);
            Pooler.Release(randomChild.gameObject);
        }
    }
}