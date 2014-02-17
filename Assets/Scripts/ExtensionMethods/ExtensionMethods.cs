using UnityEngine;
using System.Collections;

namespace ExtensionMethods {
    public static class GameObjectExtensions {
        public static void AutoCache<T>(this GameObject go, ref T cache) where T : Component {
            if (cache == null)
                cache = go.GetComponent<T>();
            else return;
        }

        public static void SyncColor(this GameObject a, GameObject b) {
            ColorController aColor = a.GetComponent<ColorController>();
            ColorController bColor = b.GetComponent<ColorController>();
            aColor.Color = bColor.Color;
        }
    }
}