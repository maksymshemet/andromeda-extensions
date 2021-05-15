using UnityEngine;
using UnityEngine.UI;

namespace DarkDynamics.Andromeda.Extensions
{
    public static class ImageExtensions
    {
        public static void Opacity(this Image image, float opacity)
        {
            var color = image.color;
            color.a = Mathf.Clamp01(opacity);
            image.color = color;
        }
    }
}