using UnityEngine;

namespace DarkDynamics.Andromeda.Extensions
{
    public static class GameObjectExtensions
    {
        public static T GetOrCreateComponent<T>(this GameObject gameObject) where T : Component
        {
            var component = gameObject.GetComponent<T>();
            if (component == null)
            {
                component = gameObject.AddComponent<T>();
            }

            return component;
        }
        
        public static void DestroyComponent<T>(this MonoBehaviour mb, float delay = 0) where T : Component
        {
            GameObject.Destroy(mb.GetComponent<T>(), delay);
        }

        public static T AddComponent<T>(this MonoBehaviour mb) where T : Component
        {
            return mb.gameObject.AddComponent<T>();
        }

        public static void ActivateGO(this MonoBehaviour mb)
        {
            mb.gameObject.SetActive(true);
        }

        public static void DeactivateGO(this MonoBehaviour mb)
        {
            mb.gameObject.SetActive(false);
        }
    }
}
