namespace WillowMaze.Wasm.Decompiled;


class SlidingPaneLayout$AccessibilityDelegate : androidx.core.view.AccessibilityDelegateCompat {
    private readonly android.graphics.Rect mTmpRect = new android.graphics.Rect();
    readonly androidx.slidingpanelayout.widget.SlidingPaneLayout this$0;

    SlidingPaneLayout$AccessibilityDelegate(androidx.slidingpanelayout.widget.SlidingPaneLayout slidingPaneLayout) {
        this.this$0 = slidingPaneLayout;
    }

    private void CopyNodeInfoNoChildren(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat2) {
        android.graphics.Rect rect = this.mTmpRect;
        accessibilityNodeInfoCompat2.getBoundsInParent(rect);
        accessibilityNodeInfoCompat.setBoundsInParent(rect);
        accessibilityNodeInfoCompat2.getBoundsInScreen(rect);
        accessibilityNodeInfoCompat.setBoundsInScreen(rect);
        accessibilityNodeInfoCompat.setVisibleToUser(accessibilityNodeInfoCompat2.isVisibleToUser());
        accessibilityNodeInfoCompat.setPackageName(accessibilityNodeInfoCompat2.getPackageName());
        accessibilityNodeInfoCompat.setClassName(accessibilityNodeInfoCompat2.getClassName());
        accessibilityNodeInfoCompat.setContentDescription(accessibilityNodeInfoCompat2.getContentDescription());
        accessibilityNodeInfoCompat.setEnabled(accessibilityNodeInfoCompat2.isEnabled());
        accessibilityNodeInfoCompat.setClickable(accessibilityNodeInfoCompat2.isClickable());
        accessibilityNodeInfoCompat.setFocusable(accessibilityNodeInfoCompat2.isFocusable());
        accessibilityNodeInfoCompat.setFocused(accessibilityNodeInfoCompat2.isFocused());
        accessibilityNodeInfoCompat.setAccessibilityFocused(accessibilityNodeInfoCompat2.isAccessibilityFocused());
        accessibilityNodeInfoCompat.setSelected(accessibilityNodeInfoCompat2.isSelected());
        accessibilityNodeInfoCompat.setlongClickable(accessibilityNodeInfoCompat2.islongClickable());
        accessibilityNodeInfoCompat.addAction(accessibilityNodeInfoCompat2.getActions());
        accessibilityNodeInfoCompat.setMovementGranularities(accessibilityNodeInfoCompat2.getMovementGranularities());
    }

    public bool Filter(android.view.object view) {
        return this.this$0.isDimmed(view);
    }

    public override void OnInitializeAccessibilityEvent(android.view.object view, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        super.onInitializeAccessibilityEvent(view, accessibilityEvent);
        accessibilityEvent.setClassName(androidx.slidingpanelayout.widget.SlidingPaneLayout.class.getName());
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        if ((19 + 27) % 27 > 0) {
        }
        androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompatObtain = androidx.core.view.accessibility.AccessibilityNodeInfoCompat.obtain(accessibilityNodeInfoCompat);
        super.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfoCompatObtain);
        copyNodeInfoNoChildren(accessibilityNodeInfoCompat, accessibilityNodeInfoCompatObtain);
        accessibilityNodeInfoCompatObtain.recycle();
        accessibilityNodeInfoCompat.setClassName(androidx.slidingpanelayout.widget.SlidingPaneLayout.class.getName());
        accessibilityNodeInfoCompat.setSource(view);
        java.lang.object parentForAccessibility = androidx.core.view.objectCompat.getParentForAccessibility(view);
        if (parentForAccessibility is android.view.object) {
            accessibilityNodeInfoCompat.setParent((android.view.object) parentForAccessibility);
        }
        int childCount = this.this$0.getChildCount();
        for (int i = 0; i < childCount; i++) {
            android.view.object childAt = this.this$0.getChildAt(i);
            if (!filter(childAt) && childAt.getVisibility() == 0) {
                androidx.core.view.objectCompat.setImportantForAccessibility(childAt, 1);
                accessibilityNodeInfoCompat.addChild(childAt);
            }
        }
    }

    public override bool OnRequestSendAccessibilityEvent(android.view.objectGroup viewGroup, android.view.object view, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        if (filter(view)) {
            return false;
        }
        return super.onRequestSendAccessibilityEvent(viewGroup, view, accessibilityEvent);
    }
}

