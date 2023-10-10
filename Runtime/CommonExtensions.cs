using UnityEngine;
using UnityEngine.SceneManagement;

// ReSharper disable once CheckNamespace
namespace DarkDynamics.Andromeda.Extensions.Runtime
{
    public static class CommonExtensions
    {
        public static float Left(this Bounds bounds) => bounds.min.x;
        
        public static float Right(this Bounds bounds) => bounds.max.x;
        
        public static float Bottom(this Bounds bounds) => bounds.min.y;
        
        public static float Top(this Bounds bounds) => bounds.max.y;
        
        public static T GetRootComponent<T>(this Scene scene) where T : Component
        {
            GameObject[] roots = scene.GetRootGameObjects();
            for (var i = 0; i < roots.Length; i++)
            {
                GameObject go = roots[i];
                if (go.TryGetComponent(out T scope))
                    return scope;
            }

            return default;
        }

        public static bool IsFalse(this bool val) => !val;
        
        public static bool IsNull(this object val) => val == null;
        
        public static bool NotNull(this object val) => val != null;
        
        public static bool NotEquals(this object obj, object val) => !obj.Equals(val);
    }
}