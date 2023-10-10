using UnityEngine;
using UnityEngine.UI;

// ReSharper disable once CheckNamespace
namespace DarkDynamics.Andromeda.Extensions.Runtime
{
    public static class ImageExtensions
    {
        public static void Opacity(this Image image, float opacity)
        {
            Color color = image.color;
            color.a = Mathf.Clamp01(opacity);
            image.color = color;
        }
    }
}