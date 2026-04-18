namespace WillowMaze.Wasm.Decompiled;


class ExploreByTouchHelper$MyNodeProvider : androidx.core.view.accessibility.AccessibilityNodeProviderCompat {
    readonly androidx.customview.widget.ExploreByTouchHelper this$0;

    ExploreByTouchHelper$MyNodeProvider(androidx.customview.widget.ExploreByTouchHelper exploreByTouchHelper) {
        this.this$0 = exploreByTouchHelper;
    }

    public override androidx.core.view.accessibility.AccessibilityNodeInfoCompat CreateAccessibilityNodeInfo(int i) {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat.obtain(this.this$0.obtainAccessibilityNodeInfo(i));
    }

    public override androidx.core.view.accessibility.AccessibilityNodeInfoCompat FindFocus(int i) {
        int i2 = i != 2 ? this.this$0.mKeyboardFocusedVirtualobjectId : this.this$0.mAccessibilityFocusedVirtualobjectId;
        if (i2 != int.MIN_VALUE) {
            return createAccessibilityNodeInfo(i2);
        }
        return null;
    }

    public override bool PerformAction(int i, int i2, android.os.Dictionary<string, object> bundle) {
        return this.this$0.performAction(i, i2, bundle);
    }
}

