namespace WillowMaze.Wasm.Decompiled;


class AccessibilityWindowInfoCompat$Api24Impl {
    private AccessibilityWindowInfoCompat$Api24Impl() {
    }

    static android.view.accessibility.AccessibilityNodeInfo GetAnchor(android.view.accessibility.AccessibilityWindowInfo accessibilityWindowInfo) {
        return accessibilityWindowInfo.getAnchor();
    }

    static java.lang.CharSequence GetTitle(android.view.accessibility.AccessibilityWindowInfo accessibilityWindowInfo) {
        return accessibilityWindowInfo.getTitle();
    }
}

