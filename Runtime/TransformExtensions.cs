using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace DarkDynamics.Andromeda.Extensions
{
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    public static class TransformExtensions
    {
        public static void Sync(this Transform transform, Transform source, bool includeLocalScale = false)
        {
            transform.SyncPosition(source);
            transform.SyncRotation(source);
            if(includeLocalScale)
                transform.SyncLocalScale(source);
        }
        public static void SyncPosition(this Transform transform, Transform source) => 
            transform.position = source.position;

        public static void SyncRotation(this Transform transform, Transform source) => 
            transform.rotation = source.rotation;

        public static void SyncLocalScale(this Transform transform, Transform source) => 
            transform.localScale = source.localScale;

        public static void SetPositionY(this Transform transform, float value)
        {
            var v = transform.position;
            v.y = value;
            transform.position = v;
        }
        
        public static void SetPositionX(this Transform transform, float value)
        {
            var v = transform.position;
            v.x = value;
            transform.position = v;
        }
        
        public static void SetPositionZ(this Transform transform, float value)
        {
            var v = transform.position;
            v.z = value;
            transform.position = v;
        }
        
        public static void SetLocalPositionY(this Transform transform, float value)
        {
            var v = transform.localPosition;
            v.y = value;
            transform.localPosition = v;
        }
        
        public static void SetLocalPositionX(this Transform transform, float value)
        {
            var v = transform.localPosition;
            v.x = value;
            transform.localPosition = v;
        }
        
        public static void SetLocalPositionZ(this Transform transform, float value)
        {
            var v = transform.localPosition;
            v.z = value;
            transform.localPosition = v;
        }
    }
}