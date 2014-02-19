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

        public static bool ColorEquals(this GameObject a, GameObject b) {
            BinaryColor aColor = a.GetComponent<ColorController>().Color;
            BinaryColor bColor = b.GetComponent<ColorController>().Color;
            return aColor == bColor;
        }

        public static float halfSpriteWidth(this GameObject go) {
            tk2dSprite sprite = go.GetComponent<tk2dSprite>();
            return sprite.GetBounds().size.x/2;
        }

        public static float halfSpriteHeight(this GameObject go) {
            tk2dSprite sprite = go.GetComponent<tk2dSprite>();
            return sprite.GetBounds().size.y/2;
        }
    }

    public static class ScreenExtensions {
        public static int ActualWidth(this Camera cam) {
            return tk2dCamera.Instance.nativeResolutionWidth;
        }

        public static int ActualHeight(this Camera cam) {
            return tk2dCamera.Instance.nativeResolutionHeight;
        }
    }
}