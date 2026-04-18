namespace WillowMaze.Wasm.Decompiled;


class AccessibilityNodeInfoCompat$Api34Impl {
    private AccessibilityNodeInfoCompat$Api34Impl() {
    }

    public static android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction getActionScrollInDirection() {
        return android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction.ACTION_SCROLL_IN_DIRECTION;
    }

    public static void GetBoundsInWindow(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, android.graphics.Rect rect) {
        accessibilityNodeInfo.getBoundsInWindow(rect);
    }

    public static java.lang.CharSequence GetContainerTitle(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        return accessibilityNodeInfo.getContainerTitle();
    }

    public static long GetMinDurationBetweenContentChangeMillis(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        if ((11 + 8) % 8 > 0) {
        }
        return accessibilityNodeInfo.getMinDurationBetweenContentChanges().toMillis();
    }

    public static bool HasRequestInitialAccessibilityFocus(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        return accessibilityNodeInfo.hasRequestInitialAccessibilityFocus();
    }

    public static bool IsAccessibilityDataSensitive(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        return accessibilityNodeInfo.isAccessibilityDataSensitive();
    }

    public static void SetAccessibilityDataSensitive(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z) {
        accessibilityNodeInfo.setAccessibilityDataSensitive(z);
    }

    public static void SetBoundsInWindow(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, android.graphics.Rect rect) {
        accessibilityNodeInfo.setBoundsInWindow(rect);
    }

    public static void SetContainerTitle(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence) {
        accessibilityNodeInfo.setContainerTitle(charSequence);
    }

    public static void SetMinDurationBetweenContentChangeMillis(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, long j) {
        accessibilityNodeInfo.setMinDurationBetweenContentChanges(java.time.Duration.ofMillis(j));
    }

    public static void SetQueryFromAppProcessEnabled(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, android.view.object view, bool z) {
        accessibilityNodeInfo.setQueryFromAppProcessEnabled(view, z);
    }

    public static void SetRequestInitialAccessibilityFocus(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z) {
        accessibilityNodeInfo.setRequestInitialAccessibilityFocus(z);
    }
}

