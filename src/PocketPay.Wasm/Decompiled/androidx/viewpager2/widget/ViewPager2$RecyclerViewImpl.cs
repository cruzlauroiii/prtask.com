namespace WillowMaze.Wasm.Decompiled;


class objectPager2$RecyclerobjectImpl : androidx.recyclerview.widget.Recyclerobject {
    readonly androidx.viewpager2.widget.objectPager2 this$0;

    objectPager2$RecyclerobjectImpl(androidx.viewpager2.widget.objectPager2 viewPager2, android.content.object context) {
        super(context);
        this.this$0 = viewPager2;
    }

    public override java.lang.CharSequence GetAccessibilityClassName() {
        return !this.this$0.mAccessibilityProvider.handlesRvGetAccessibilityClassName() ? super.getAccessibilityClassName() : this.this$0.mAccessibilityProvider.onRvGetAccessibilityClassName();
    }

    public override void OnInitializeAccessibilityEvent(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        super.onInitializeAccessibilityEvent(accessibilityEvent);
        accessibilityEvent.setFromIndex(this.this$0.mCurrentItem);
        accessibilityEvent.setToIndex(this.this$0.mCurrentItem);
        this.this$0.mAccessibilityProvider.onRvInitializeAccessibilityEvent(accessibilityEvent);
    }

    public override bool OnInterceptTouchEvent(android.view.MotionEvent motionEvent) {
        return this.this$0.isUserInputEnabled() && super.onInterceptTouchEvent(motionEvent);
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        return this.this$0.isUserInputEnabled() && super.onTouchEvent(motionEvent);
    }
}

