using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace DarkDynamics.Studio.Andromeda.Extensions
{
    public static class LayerMaskExtensions
    {
        public static int ToLayerNumber(this LayerMask layerMask)
        {
            return Mathf.FloorToInt(Mathf.Log(layerMask, 2));
        }

        public static void SetLayerMask(this GameObject go, LayerMask layerMask, bool recursive = true)
        {
            SetLayerMask(go, ToLayerNumber(layerMask), recursive);
        }

        public static void SetLayerMask(this GameObject go, int layerMask, bool recursive = true)
        {
            go.layer = layerMask;

            if (recursive)
            {
                foreach (Transform child in go.transform)
                {
                    SetLayerMask(child.gameObject, layerMask);
                }
            }
        }
    }
}