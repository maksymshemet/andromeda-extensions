using UnityEngine;

namespace DarkDynamics.Andromeda.Extensions
{
    public static class QuaternionExtensions
    {
        public static Quaternion ClampRotationAroundXAxis(this Quaternion q, float minimumX, float maximumX)
        {
            q.x /= q.w;
            q.y /= q.w;
            q.z /= q.w;
            q.w = 1.0f;

            float angleX = 2.0f * Mathf.Rad2Deg * Mathf.Atan(q.x);

            angleX = Mathf.Clamp(angleX, minimumX, maximumX);

            q.x = Mathf.Tan(0.5f * Mathf.Deg2Rad * angleX);

            return q;
        }

        public static Quaternion ClampRotationAroundYAxis(this Quaternion q, float minimumY, float maximumY)
        {
            q.x /= q.w;
            q.y /= q.w;
            q.z /= q.w;
            q.w = 1.0f;

            float angleY = 2.0f * Mathf.Rad2Deg * Mathf.Atan(q.y);

            angleY = Mathf.Clamp(angleY, minimumY, maximumY);

            q.y = Mathf.Tan(0.5f * Mathf.Deg2Rad * angleY);

            return q;
        }

        public static Quaternion ClampRotationAroundZAxis(this Quaternion q, float minimumZ, float maximumZ)
        {
            q.x /= q.w;
            q.y /= q.w;
            q.z /= q.w;
            q.w = 1.0f;

            float angleZ = 2.0f * Mathf.Rad2Deg * Mathf.Atan(q.z);

            angleZ = Mathf.Clamp(angleZ, minimumZ, maximumZ);

            q.y = Mathf.Tan(0.5f * Mathf.Deg2Rad * angleZ);

            return q;
        }
    }
}