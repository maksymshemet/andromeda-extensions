using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

// ReSharper disable once CheckNamespace
namespace DarkDynamics.Andromeda.Extensions.Runtime
{
    public static class CollectionExtensions
    {
        public static void RemoveAllIf<T>(this List<T> list, Predicate<T> predicate)
        {
            for (var i = 0; i < list.Count; i++)
            {
                if(predicate(list[i]))
                    list.RemoveAt(i);
            }
        }
        
        public static bool IsEmpty<T>(this List<T> list) => list.Count == 0;
        public static bool IsEmpty<T>(this T[] array) => array.Length == 0;
        public static bool IsEmpty<T>(this HashSet<T> list) => list.Count == 0;
        
        public static bool IsNotEmpty<T>(this List<T> list) => !IsEmpty(list);
        public static bool IsNotEmpty<T>(this HashSet<T> list) => !IsEmpty(list);
        public static bool IsNotEmpty<T>(this T[] array) => !IsEmpty(array);

        public static bool IsNullOrEmpty<T>(this List<T> list) => list == null || IsEmpty(list);
        public static bool IsNullOrEmpty<T>(this HashSet<T> list) => list == null || IsEmpty(list);
        public static bool IsNullOrEmpty<T>(this T[] array) => array == null || IsEmpty(array);
        
        public static bool IsNotNullNotEmpty<T>(this List<T> list) => list is { Count: > 0 };
        public static bool IsNotNullNotEmpty<T>(this HashSet<T> list) => list is { Count: > 0 };
        public static bool IsNotNullNotEmpty<T>(this T[] array) => array is { Length: > 0 };

        public static bool TryGetAndRemove<TKey, TValue>(this Dictionary<TKey, TValue> dict, in TKey key,
            out TValue value)
        {
            if (dict.TryGetValue(key, out value))
            {
                dict.Remove(key);
                return true;
            }

            return false;
        }
        
        public static T UnityRandom<T>(this List<T> list)
        {
            return list[Random.Range(0, list.Count)];
        }
    }
}