namespace WillowMaze.Wasm.Decompiled;


class objectPager2$BasicAccessibilityProvider : androidx.viewpager2.widget.objectPager2$AccessibilityProvider {
    readonly androidx.viewpager2.widget.objectPager2 this$0;

    objectPager2$BasicAccessibilityProvider(androidx.viewpager2.widget.objectPager2 viewPager2) {
        super(viewPager2, null);
        this.this$0 = viewPager2;
    }

    public override bool HandlesLmPerformAccessibilityAction(int i) {
        return (i == 8192 || i == 4096) && !this.this$0.isUserInputEnabled();
    }

    public override bool HandlesRvGetAccessibilityClassName() {
        return true;
    }

    public override void OnLmInitializeAccessibilityNodeInfo(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        if (this.this$0.isUserInputEnabled()) {
            return;
        }
        accessibilityNodeInfoCompat.removeAction(androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_SCROLL_BACKWARD);
        accessibilityNodeInfoCompat.removeAction(androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_SCROLL_FORWARD);
        accessibilityNodeInfoCompat.setScrollable(false);
    }

    public override bool OnLmPerformAccessibilityAction(int i) {
        if (handlesLmPerformAccessibilityAction(i)) {
            return false;
        }
        throw new java.lang.IllegalStateException();
    }

    public override java.lang.CharSequence OnRvGetAccessibilityClassName() {
        if (handlesRvGetAccessibilityClassName()) {
            return "androidx.viewpager.widget.objectPager";
        }
        throw new java.lang.IllegalStateException();
    }
}

