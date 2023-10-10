using System.Diagnostics.CodeAnalysis;
using UnityEngine;

// ReSharper disable once CheckNamespace
namespace DarkDynamics.Andromeda.Extensions.Runtime
{
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    public static class RectTransformExtensions
    {
        public static RectTransform SetLeft( this RectTransform rt, float x )
        {
            rt.offsetMin = new Vector2( x, rt.offsetMin.y );
            return rt;
        }
 
        public static RectTransform SetRight( this RectTransform rt, float x )
        {
            rt.offsetMax = new Vector2( -x, rt.offsetMax.y );
            return rt;
        }
 
        public static RectTransform SetBottom( this RectTransform rt, float y )
        {
            rt.offsetMin = new Vector2( rt.offsetMin.x, y );
            return rt;
        }
 
        public static RectTransform SetTop( this RectTransform rt, float y )
        {
            rt.offsetMax = new Vector2( rt.offsetMax.x, -y );
            return rt;
        }
        
        public static float GetTop( this RectTransform rt)
        {
            return -rt.offsetMax.y;
        }
        
        public static void SetDefaultScale(this RectTransform trans)
        {
            trans.localScale = new Vector3(1, 1, 1);
        }

        public static void SetPivotAndAnchors(this RectTransform trans, Vector2 vec)
        {
            trans.pivot = vec;
            trans.anchorMin = vec;
            trans.anchorMax = vec;
        }

        public static Vector2 GetSize(this RectTransform trans)
        {
            return trans.rect.size;
        }

        public static float GetWidth(this RectTransform trans)
        {
            return trans.rect.width;
        }

        public static float GetHeight(this RectTransform trans)
        {
            return trans.rect.height;
        }

        public static void SetPositionOfPivot(this RectTransform trans, Vector2 newPos)
        {
            trans.localPosition = new Vector3(newPos.x, newPos.y, trans.localPosition.z);
        }

        public static void SetLeftBottomPosition(this RectTransform trans, Vector2 newPos)
        {
            trans.localPosition = new Vector3(newPos.x + (trans.pivot.x * trans.rect.width),
                newPos.y + (trans.pivot.y * trans.rect.height), trans.localPosition.z);
        }

        public static void SetLeftTopPosition(this RectTransform trans, Vector2 newPos)
        {
            trans.localPosition = new Vector3(newPos.x + (trans.pivot.x * trans.rect.width),
                newPos.y - ((1f - trans.pivot.y) * trans.rect.height), trans.localPosition.z);
        }

        public static void SetRightBottomPosition(this RectTransform trans, Vector2 newPos)
        {
            trans.localPosition = new Vector3(newPos.x - ((1f - trans.pivot.x) * trans.rect.width),
                newPos.y + (trans.pivot.y * trans.rect.height), trans.localPosition.z);
        }

        public static void SetRightTopPosition(this RectTransform trans, Vector2 newPos)
        {
            trans.localPosition = new Vector3(newPos.x - ((1f - trans.pivot.x) * trans.rect.width),
                newPos.y - ((1f - trans.pivot.y) * trans.rect.height), trans.localPosition.z);
        }

        public static void SetSize(this RectTransform trans, Vector2 newSize)
        {
            Vector2 oldSize = trans.rect.size;
            Vector2 deltaSize = newSize - oldSize;
            Vector2 pivot = trans.pivot;
            trans.offsetMin -= new Vector2(deltaSize.x * pivot.x, deltaSize.y * pivot.y);
            trans.offsetMax += new Vector2(deltaSize.x * (1f - pivot.x), deltaSize.y * (1f - pivot.y));
        }

        public static void SetWidth(this RectTransform trans, float newSize)
        {
            SetSize(trans, new Vector2(newSize, trans.rect.size.y));
        }

        public static void SetHeight(this RectTransform trans, float newSize)
        {
            SetSize(trans, new Vector2(trans.rect.size.x, newSize));
        }

        public static void SetRectPosX(this RectTransform trans, float x)
        {
            trans.anchoredPosition = new Vector2(x, trans.anchoredPosition.y);
        }
        
        public static void SetRectPosY(this RectTransform trans, float y)
        {
            trans.anchoredPosition = new Vector2(trans.anchoredPosition.x, y);
        }
    }
}
