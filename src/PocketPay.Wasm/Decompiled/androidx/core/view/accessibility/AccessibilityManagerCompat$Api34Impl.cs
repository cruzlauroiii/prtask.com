namespace WillowMaze.Wasm.Decompiled;


class AccessibilityManagerCompat$Api34Impl {
    private AccessibilityManagerCompat$Api34Impl() {
    }

    static bool IsRequestFromAccessibilityTool(android.view.accessibility.AccessibilityManager accessibilityManager) {
        return accessibilityManager.isRequestFromAccessibilityTool();
    }
}

