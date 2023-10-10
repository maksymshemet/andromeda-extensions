using UnityEngine;

// ReSharper disable once CheckNamespace
namespace DarkDynamics.Andromeda.Extensions.Runtime
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
        
        public static bool ApproximatelyEqualsTo(this Vector3 @this, Vector3 target, float tolerance) =>
            @this.x.ApproximatelyEqualsTo(target.x, tolerance)
            && @this.y.ApproximatelyEqualsTo(target.y, tolerance)
            && @this.z.ApproximatelyEqualsTo(target.z, tolerance);

        public static Vector3 ToVector3XY(this Vector2 @this, float z = 0) => 
            new Vector3(@this.x, @this.y, z);
        
        public static Vector2 ToVector2XY(this Vector3 @this) => 
            new Vector2(@this.x, @this.y);
        
        public static Vector2Int CopyWithY(this Vector2Int vector, int value) => 
            new Vector2Int(vector.x, value);
        
        public static Vector2Int CopyWithX(this Vector2Int vector, int value) => 
            new Vector2Int(value, vector.y);
        
        public static float CrossProduct(this Vector2 @this, Vector2 target) =>
            @this.x * target.y - @this.y * target.x;

        public static float Angle360(this Vector3 @this, Vector3 target, Vector3 axis)
        {
            // Returns the angle between -180 and 180.
            float angle = Vector3.SignedAngle(@this, target, axis); 
            if(angle < 0)
            {
                angle = 360 - angle * -1;
            }
            return angle;
        }

        public static Vector2 MoveAroundRad(this Vector2 @this, Vector2 target, float rad)
        {
            Vector2 v = @this - target;

            //rotate x and y
            float x = v.x * Mathf.Cos(rad) + v.y * Mathf.Sin(rad);
            float y = v.y * Mathf.Cos(rad) - v.x * Mathf.Sin(rad);

            //move back to center
            return new Vector2(x, y) + target;
        }
    }
}
