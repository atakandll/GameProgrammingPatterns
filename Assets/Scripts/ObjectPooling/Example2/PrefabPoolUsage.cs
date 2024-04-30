using UnityEngine;
using Utils.Attributes;

namespace ObjectPooling.Example2
{
    public class PrefabPoolUsage : MonoBehaviour
    {
        [Tooltip("The Pooler")] [SerializeField]
        private APooler Pooler;

        [Tooltip("The Pooled GameObject")] [SerializeField]
        private GameObject[] Prefabs;

        [Tooltip("Objeler arası yatay mesafe")] [SerializeField]
        private float distanceBetweenObjectsX = 2.5f; 

        [Tooltip("Objeler arası dikey mesafe")] [SerializeField]
        private float distanceBetweenObjectsY = 1.5f;

        private int objectsPerRow = 10; 

        private void Start()
        {
            for (int row = 0; row < 10; row++) 
            {
                for (int column = 0; column < objectsPerRow; column++) 
                {
                    CreateObjectAtPosition(row, column);
                }
            }
        }
        private void CreateObjectAtPosition(int row, int column)
        {
            var randomIndex = Random.Range(0, Prefabs.Length);
            var randomObj = Prefabs[randomIndex];
            var obj = Pooler.Get<APooled>(randomObj);

            Vector3 newPosition = transform.position + new Vector3(
                column * distanceBetweenObjectsX, 
                -row * distanceBetweenObjectsY, 
                0); 

            obj.transform.position = newPosition;
            obj.transform.SetParent(transform);
        }

        [Button]
        public void PoolRandomObject()
        {
            var randomIndex = Random.Range(0, Prefabs.Length);
            var randomObj = Prefabs[randomIndex];
            var obj = Pooler.Get<APooled>(randomObj);
            obj.transform.SetParent(transform);
        }
        
        [Button]
        public void ReleaseRandomChild(GameObject objToRelease)
        {
            if (objToRelease != null)
            {
                Pooler.Release(objToRelease);
            }
        }
    }
}