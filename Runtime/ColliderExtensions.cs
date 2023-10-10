using UnityEngine;

// ReSharper disable once CheckNamespace
namespace DarkDynamics.Andromeda.Extensions.Runtime
{
    public static class ColliderExtensions
    {
        public static Vector2 RandomPointInside(this CircleCollider2D circle)
        {
            Transform transform = circle.transform;
            Vector2 random = Random.insideUnitCircle * circle.radius;
            var result = new Vector2(transform.position.x + random.x,transform.position.y + random.y);
            return result;
        }
    }
}