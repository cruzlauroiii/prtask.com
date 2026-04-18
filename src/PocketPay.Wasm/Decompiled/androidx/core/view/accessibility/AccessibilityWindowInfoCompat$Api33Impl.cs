namespace WillowMaze.Wasm.Decompiled;


class AccessibilityWindowInfoCompat$Api33Impl {
    private AccessibilityWindowInfoCompat$Api33Impl() {
    }

    static int GetDisplayId(android.view.accessibility.AccessibilityWindowInfo accessibilityWindowInfo) {
        return accessibilityWindowInfo.getDisplayId();
    }

    static void GetRegionInScreen(android.view.accessibility.AccessibilityWindowInfo accessibilityWindowInfo, android.graphics.Region region) {
        accessibilityWindowInfo.getRegionInScreen(region);
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat GetRoot(java.lang.object obj, int i) {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat.wrapNonNullInstance(((android.view.accessibility.AccessibilityWindowInfo) obj).getRoot(i));
    }
}

