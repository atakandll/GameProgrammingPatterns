using UnityEngine;

namespace Singleton.Example1
{
    public class PersistentMB : MonoBehaviour
    {
        private void Awake() => PersistenceUsage.Instance.PrintRandomValue();

    }
}