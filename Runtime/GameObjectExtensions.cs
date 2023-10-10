using UnityEngine;

// ReSharper disable once CheckNamespace
namespace DarkDynamics.Andromeda.Extensions.Runtime
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
            Object.Destroy(mb.GetComponent<T>(), delay);
        }

        public static T AddComponent<T>(this MonoBehaviour mb) where T : Component
        {
            return mb.gameObject.AddComponent<T>();
        }
    }
}
