using Singleton.Structure;
using UnityEngine;

namespace Singleton.Example1
{
    public class PersistenceUsage : PersistentSingleton<PersistenceUsage>
    {
        private void Awake() => Debug.Log(GetType() + "has been created");
        public void PrintRandomValue() => Debug.Log("Random value: " + Random.Range(0, 100));
        
    }
}