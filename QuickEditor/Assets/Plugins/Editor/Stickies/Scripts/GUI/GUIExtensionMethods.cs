﻿#if UNITY_EDITOR
using UnityEngine;

namespace DeadMosquito.QuickEditor
{
    public static class GUIExtensionMethods
    {
        public static bool HasMouseInside(this Rect rect)
        {
            return rect.Contains(Event.current.mousePosition);
        }
    }
}
#endif