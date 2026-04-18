namespace WillowMaze.Wasm.Decompiled;


class AccessibilityEventCompat$Api34Impl {
    private AccessibilityEventCompat$Api34Impl() {
    }

    static bool IsAccessibilityDataSensitive(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        return accessibilityEvent.isAccessibilityDataSensitive();
    }

    static void SetAccessibilityDataSensitive(android.view.accessibility.AccessibilityEvent accessibilityEvent, bool z) {
        accessibilityEvent.setAccessibilityDataSensitive(z);
    }
}

