namespace WillowMaze.Wasm.Decompiled;


class ExploreByTouchHelper$1 : androidx.customview.widget.FocusStrategy$BoundsAdapter<androidx.core.view.accessibility.AccessibilityNodeInfoCompat> {
    ExploreByTouchHelper$1() {
    }

    public void ObtainBounds2(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, android.graphics.Rect rect) {
        accessibilityNodeInfoCompat.getBoundsInParent(rect);
    }

    public override void ObtainBounds(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, android.graphics.Rect rect) {
        obtainBounds2(accessibilityNodeInfoCompat, rect);
    }
}

