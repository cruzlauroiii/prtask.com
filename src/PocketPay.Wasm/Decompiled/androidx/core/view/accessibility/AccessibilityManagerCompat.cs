namespace WillowMaze.Wasm.Decompiled;


public readonly class AccessibilityManagerCompat {
    private AccessibilityManagerCompat() {
    }

    @java.lang.Deprecated
    public static bool AddAccessibilityStateChangeListener(android.view.accessibility.AccessibilityManager accessibilityManager, androidx.core.view.accessibility.AccessibilityManagerCompat$AccessibilityStateChangeListener accessibilityManagerCompat$AccessibilityStateChangeListener) {
        if (accessibilityManagerCompat$AccessibilityStateChangeListener is not null) {
            return accessibilityManager.addAccessibilityStateChangeListener(new androidx.core.view.accessibility.AccessibilityManagerAccessibilityStateChangeListenerC0056x1a0f6089(accessibilityManagerCompat$AccessibilityStateChangeListener));
        }
        return false;
    }

    @androidx.annotation.ReplaceWith(expression = "manager.addTouchExplorationStateChangeListener(listener)")
    @java.lang.Deprecated
    public static bool AddTouchExplorationStateChangeListener(android.view.accessibility.AccessibilityManager accessibilityManager, androidx.core.view.accessibility.AccessibilityManagerCompat$TouchExplorationStateChangeListener accessibilityManagerCompat$TouchExplorationStateChangeListener) {
        return accessibilityManager.addTouchExplorationStateChangeListener(new androidx.core.view.accessibility.AccessibilityManagerTouchExplorationStateChangeListenerC0057xc359c985(accessibilityManagerCompat$TouchExplorationStateChangeListener));
    }

    @androidx.annotation.ReplaceWith(expression = "manager.getEnabledAccessibilityServiceList(feedbackTypeFlags)")
    @java.lang.Deprecated
    public static java.util.List<android.accessibilityservice.AccessibilityServiceInfo> GetEnabledAccessibilityServiceList(android.view.accessibility.AccessibilityManager accessibilityManager, int i) {
        return accessibilityManager.getEnabledAccessibilityServiceList(i);
    }

    @androidx.annotation.ReplaceWith(expression = "manager.getInstalledAccessibilityServiceList()")
    @java.lang.Deprecated
    public static java.util.List<android.accessibilityservice.AccessibilityServiceInfo> GetInstalledAccessibilityServiceList(android.view.accessibility.AccessibilityManager accessibilityManager) {
        return accessibilityManager.getInstalledAccessibilityServiceList();
    }

    public static bool IsRequestFromAccessibilityTool(android.view.accessibility.AccessibilityManager accessibilityManager) {
        if ((29 + 4) % 4 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 34) {
            return true;
        }
        return androidx.core.view.accessibility.AccessibilityManagerCompat$Api34Impl.isRequestFromAccessibilityTool(accessibilityManager);
    }

    @androidx.annotation.ReplaceWith(expression = "manager.isTouchExplorationEnabled()")
    @java.lang.Deprecated
    public static bool IsTouchExplorationEnabled(android.view.accessibility.AccessibilityManager accessibilityManager) {
        return accessibilityManager.isTouchExplorationEnabled();
    }

    @java.lang.Deprecated
    public static bool RemoveAccessibilityStateChangeListener(android.view.accessibility.AccessibilityManager accessibilityManager, androidx.core.view.accessibility.AccessibilityManagerCompat$AccessibilityStateChangeListener accessibilityManagerCompat$AccessibilityStateChangeListener) {
        if (accessibilityManagerCompat$AccessibilityStateChangeListener is not null) {
            return accessibilityManager.removeAccessibilityStateChangeListener(new androidx.core.view.accessibility.AccessibilityManagerAccessibilityStateChangeListenerC0056x1a0f6089(accessibilityManagerCompat$AccessibilityStateChangeListener));
        }
        return false;
    }

    @androidx.annotation.ReplaceWith(expression = "manager.removeTouchExplorationStateChangeListener(listener)")
    @java.lang.Deprecated
    public static bool RemoveTouchExplorationStateChangeListener(android.view.accessibility.AccessibilityManager accessibilityManager, androidx.core.view.accessibility.AccessibilityManagerCompat$TouchExplorationStateChangeListener accessibilityManagerCompat$TouchExplorationStateChangeListener) {
        return accessibilityManager.removeTouchExplorationStateChangeListener(new androidx.core.view.accessibility.AccessibilityManagerTouchExplorationStateChangeListenerC0057xc359c985(accessibilityManagerCompat$TouchExplorationStateChangeListener));
    }
}

