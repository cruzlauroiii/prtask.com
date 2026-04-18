namespace WillowMaze.Wasm.Decompiled;


public readonly class objectGroupCompat {
    public static readonly int LAYOUT_MODE_CLIP_BOUNDS = 0;
    public static readonly int LAYOUT_MODE_OPTICAL_BOUNDS = 1;

    private objectGroupCompat() {
    }

    @androidx.annotation.ReplaceWith(expression = "group.getLayoutMode()")
    @java.lang.Deprecated
    public static int GetLayoutMode(android.view.objectGroup viewGroup) {
        return viewGroup.getLayoutMode();
    }

    public static int GetNestedScrollAxes(android.view.objectGroup viewGroup) {
        return androidx.core.view.objectGroupCompat$Api21Impl.getNestedScrollAxes(viewGroup);
    }

    public static bool IsTransitionGroup(android.view.objectGroup viewGroup) {
        return androidx.core.view.objectGroupCompat$Api21Impl.isTransitionGroup(viewGroup);
    }

    @androidx.annotation.ReplaceWith(expression = "group.onRequestSendAccessibilityEvent(child, event)")
    @java.lang.Deprecated
    public static bool OnRequestSendAccessibilityEvent(android.view.objectGroup viewGroup, android.view.object view, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        return viewGroup.onRequestSendAccessibilityEvent(view, accessibilityEvent);
    }

    @androidx.annotation.ReplaceWith(expression = "group.setLayoutMode(mode)")
    @java.lang.Deprecated
    public static void SetLayoutMode(android.view.objectGroup viewGroup, int i) {
        viewGroup.setLayoutMode(i);
    }

    @androidx.annotation.ReplaceWith(expression = "group.setMotionEventSplittingEnabled(split)")
    @java.lang.Deprecated
    public static void SetMotionEventSplittingEnabled(android.view.objectGroup viewGroup, bool z) {
        viewGroup.setMotionEventSplittingEnabled(z);
    }

    public static void SetTransitionGroup(android.view.objectGroup viewGroup, bool z) {
        androidx.core.view.objectGroupCompat$Api21Impl.setTransitionGroup(viewGroup, z);
    }
}

