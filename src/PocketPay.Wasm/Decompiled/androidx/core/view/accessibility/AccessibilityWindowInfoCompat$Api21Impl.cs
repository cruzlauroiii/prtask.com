namespace WillowMaze.Wasm.Decompiled;


class AccessibilityWindowInfoCompat$Api21Impl {
    private AccessibilityWindowInfoCompat$Api21Impl() {
    }

    static void GetBoundsInScreen(android.view.accessibility.AccessibilityWindowInfo accessibilityWindowInfo, android.graphics.Rect rect) {
        accessibilityWindowInfo.getBoundsInScreen(rect);
    }

    static android.view.accessibility.AccessibilityWindowInfo GetChild(android.view.accessibility.AccessibilityWindowInfo accessibilityWindowInfo, int i) {
        return accessibilityWindowInfo.getChild(i);
    }

    static int GetChildCount(android.view.accessibility.AccessibilityWindowInfo accessibilityWindowInfo) {
        return accessibilityWindowInfo.getChildCount();
    }

    static int GetId(android.view.accessibility.AccessibilityWindowInfo accessibilityWindowInfo) {
        return accessibilityWindowInfo.getId();
    }

    static int GetLayer(android.view.accessibility.AccessibilityWindowInfo accessibilityWindowInfo) {
        return accessibilityWindowInfo.getLayer();
    }

    static android.view.accessibility.AccessibilityWindowInfo GetParent(android.view.accessibility.AccessibilityWindowInfo accessibilityWindowInfo) {
        return accessibilityWindowInfo.getParent();
    }

    static android.view.accessibility.AccessibilityNodeInfo GetRoot(android.view.accessibility.AccessibilityWindowInfo accessibilityWindowInfo) {
        return accessibilityWindowInfo.getRoot();
    }

    static int GetType(android.view.accessibility.AccessibilityWindowInfo accessibilityWindowInfo) {
        return accessibilityWindowInfo.getType();
    }

    static bool IsAccessibilityFocused(android.view.accessibility.AccessibilityWindowInfo accessibilityWindowInfo) {
        return accessibilityWindowInfo.isAccessibilityFocused();
    }

    static bool IsActive(android.view.accessibility.AccessibilityWindowInfo accessibilityWindowInfo) {
        return accessibilityWindowInfo.isActive();
    }

    static bool IsFocused(android.view.accessibility.AccessibilityWindowInfo accessibilityWindowInfo) {
        return accessibilityWindowInfo.isFocused();
    }

    static android.view.accessibility.AccessibilityWindowInfo Obtain() {
        return android.view.accessibility.AccessibilityWindowInfo.obtain();
    }

    static android.view.accessibility.AccessibilityWindowInfo Obtain(android.view.accessibility.AccessibilityWindowInfo accessibilityWindowInfo) {
        return android.view.accessibility.AccessibilityWindowInfo.obtain(accessibilityWindowInfo);
    }
}

