using UnityEngine;

namespace Singleton.Structure
{
    public class PersistenceSingleton<T> : MonoBehaviour where T : Component
    {
        private static T instance;

        public static T Instance
        {
            get
            {
                if(instance == null)
                    CreateInstance();
                else
                    HandleDuplication();

                return instance;

            }
        }

        private static void CreateInstance()
        {
            var go = new GameObject(typeof(T).ToString());
            instance = go.AddComponent<T>();
        }

        private static void HandleDuplication()
        {
            var copies = FindObjectsOfType(typeof(T));
            
            foreach (var copy in copies)
            {
                
                if(copy!=instance)
                    Destroy(copy);
            }
        }

    }
}