using UnityEngine;

namespace DarkDynamics.Andromeda.Extensions
{
    public static class VectorExtensions
    {
        public static Vector3 CopyWithX(this Vector3 vector, float value) => 
            new Vector3(value, vector.y, vector.z);

        public static Vector2 CopyWithX(this Vector2 vector, float value) => 
            new Vector2(value, vector.y);
        
        public static Vector3 CopyWithY(this ref Vector3 vector, float value) => 
            new Vector3(vector.x, value, vector.z);
        
        public static Vector2 CopyWithY(this ref Vector2 vector, float value) => 
            new Vector2(vector.x, value);

        public static Vector3 CopyWithZ(this Vector3 vector, float value) => 
            new Vector3(vector.x, vector.y, value);

        public static Vector3 PointTo(this Vector3 source, Vector3 target) => 
            target - source;
        
        public static Vector2 PointTo(this Vector2 source, Vector2 target) => 
            target - source;

        public static int CompareLengthTo(this Vector3 source, Vector3 target) => 
            source.sqrMagnitude.CompareTo(target.sqrMagnitude);
        
        public static int CompareLengthTo(this Vector2 source, Vector2 target) => 
            source.sqrMagnitude.CompareTo(target.sqrMagnitude);
    }
}
