using System;
using UnityEngine;
// ReSharper disable once CheckNamespace
namespace DarkDynamics.Andromeda.Extensions.Runtime
{
    public static class QuaternionExtensions
    {
        public enum Axis
        {
            X, Y, Z
        }

        public static Quaternion ClampRotationAround(this Quaternion q, Axis axis, float min, float max)
        {
            q.x /= q.w;
            q.y /= q.w;
            q.z /= q.w;
            q.w = 1.0f;

            float GetClampedAngel(float val)
            {
                float angle = 2.0f * Mathf.Rad2Deg * Mathf.Atan(val);
                angle = Mathf.Clamp(angle, min, max);
                return Mathf.Tan(0.5f * Mathf.Deg2Rad * angle);
            }
            
            switch (axis)
            {
                case Axis.X:
                    q.x = GetClampedAngel(q.x);
                    break;
                case Axis.Y:
                    q.y = GetClampedAngel(q.y);
                    break;
                case Axis.Z:
                    q.z = GetClampedAngel(q.z);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(axis), axis, null);
            }

            return q;
        }
    }
}