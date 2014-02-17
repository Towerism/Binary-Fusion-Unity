using UnityEngine;
using System.Collections;

namespace ExtensionMethods {
    public static class GameObjectExtensions {
        public static void AutoCache<T>(this GameObject go, ref T cache, T component) where T : Component {
            if (cache == null)
                cache = component;
            else return;
        } 
    }
}