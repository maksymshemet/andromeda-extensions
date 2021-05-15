using UnityEngine;

namespace DarkDynamics.Andromeda.Extensions
{
    public static class ColliderExtensions
    {
        public static Vector2 RandomPointInside(this CircleCollider2D circle)
        {
            var transform = circle.transform;
            var random = Random.insideUnitCircle * circle.radius;
            var result = new Vector2(transform.position.x + random.x,transform.position.y + random.y);
            return result;
        }
    }
}