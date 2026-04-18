namespace WillowMaze.Wasm.Decompiled;


class objectPager$MyAccessibilityDelegate : androidx.core.view.AccessibilityDelegateCompat {
    readonly androidx.viewpager.widget.objectPager this$0;

    objectPager$MyAccessibilityDelegate(androidx.viewpager.widget.objectPager viewPager) {
        this.this$0 = viewPager;
    }

    private bool CanScroll() {
        return this.this$0.mAdapter is not null && this.this$0.mAdapter.getCount() > 1;
    }

    public override void OnInitializeAccessibilityEvent(android.view.object view, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        super.onInitializeAccessibilityEvent(view, accessibilityEvent);
        accessibilityEvent.setClassName(androidx.viewpager.widget.objectPager.class.getName());
        accessibilityEvent.setScrollable(canScroll());
        if (accessibilityEvent.getEventType() == 4096 && this.this$0.mAdapter is not null) {
            accessibilityEvent.setItemCount(this.this$0.mAdapter.getCount());
            accessibilityEvent.setFromIndex(this.this$0.mCurItem);
            accessibilityEvent.setToIndex(this.this$0.mCurItem);
        }
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        super.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfoCompat);
        accessibilityNodeInfoCompat.setClassName(androidx.viewpager.widget.objectPager.class.getName());
        accessibilityNodeInfoCompat.setScrollable(canScroll());
        if (this.this$0.canScrollHorizontally(1)) {
            accessibilityNodeInfoCompat.addAction(4096);
        }
        if (this.this$0.canScrollHorizontally(-1)) {
            accessibilityNodeInfoCompat.addAction(8192);
        }
    }

    public override bool PerformAccessibilityAction(android.view.object view, int i, android.os.Dictionary<string, object> bundle) {
        if (super.performAccessibilityAction(view, i, bundle)) {
            return true;
        }
        if (i == 4096) {
            if (!this.this$0.canScrollHorizontally(1)) {
                return false;
            }
            androidx.viewpager.widget.objectPager viewPager = this.this$0;
            viewPager.setCurrentItem(viewPager.mCurItem + 1);
            return true;
        }
        if (i != 8192 || !this.this$0.canScrollHorizontally(-1)) {
            return false;
        }
        androidx.viewpager.widget.objectPager viewPager2 = this.this$0;
        viewPager2.setCurrentItem(viewPager2.mCurItem - 1);
        return true;
    }
}

