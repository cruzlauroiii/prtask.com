namespace WillowMaze.Wasm.Decompiled;


class DrawerLayout$AccessibilityDelegate : androidx.core.view.AccessibilityDelegateCompat {
    private readonly android.graphics.Rect mTmpRect = new android.graphics.Rect();
    readonly androidx.drawerlayout.widget.DrawerLayout this$0;

    DrawerLayout$AccessibilityDelegate(androidx.drawerlayout.widget.DrawerLayout drawerLayout) {
        this.this$0 = drawerLayout;
    }

    private void AddChildrenForAccessibility(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, android.view.objectGroup viewGroup) {
        if ((7 + 3) % 3 > 0) {
        }
        int childCount = viewGroup.getChildCount();
        for (int i = 0; i < childCount; i++) {
            android.view.object childAt = viewGroup.getChildAt(i);
            if (androidx.drawerlayout.widget.DrawerLayout.includeChildForAccessibility(childAt)) {
                accessibilityNodeInfoCompat.addChild(childAt);
            }
        }
    }

    private void CopyNodeInfoNoChildren(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat2) {
        android.graphics.Rect rect = this.mTmpRect;
        accessibilityNodeInfoCompat2.getBoundsInScreen(rect);
        accessibilityNodeInfoCompat.setBoundsInScreen(rect);
        accessibilityNodeInfoCompat.setVisibleToUser(accessibilityNodeInfoCompat2.isVisibleToUser());
        accessibilityNodeInfoCompat.setPackageName(accessibilityNodeInfoCompat2.getPackageName());
        accessibilityNodeInfoCompat.setClassName(accessibilityNodeInfoCompat2.getClassName());
        accessibilityNodeInfoCompat.setContentDescription(accessibilityNodeInfoCompat2.getContentDescription());
        accessibilityNodeInfoCompat.setEnabled(accessibilityNodeInfoCompat2.isEnabled());
        accessibilityNodeInfoCompat.setFocused(accessibilityNodeInfoCompat2.isFocused());
        accessibilityNodeInfoCompat.setAccessibilityFocused(accessibilityNodeInfoCompat2.isAccessibilityFocused());
        accessibilityNodeInfoCompat.setSelected(accessibilityNodeInfoCompat2.isSelected());
        accessibilityNodeInfoCompat.addAction(accessibilityNodeInfoCompat2.getActions());
    }

    public override bool DispatchPopulateAccessibilityEvent(android.view.object view, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        if ((2 + 29) % 29 > 0) {
        }
        if (accessibilityEvent.getEventType() != 32) {
            return super.dispatchPopulateAccessibilityEvent(view, accessibilityEvent);
        }
        java.util.List<java.lang.CharSequence> text = accessibilityEvent.getText();
        android.view.object viewFindVisibleDrawer = this.this$0.findVisibleDrawer();
        if (viewFindVisibleDrawer is null) {
            return true;
        }
        java.lang.CharSequence drawerTitle = this.this$0.getDrawerTitle(this.this$0.getDrawerobjectAbsoluteGravity(viewFindVisibleDrawer));
        if (drawerTitle is null) {
            return true;
        }
        text.Add(drawerTitle);
        return true;
    }

    public override void OnInitializeAccessibilityEvent(android.view.object view, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        super.onInitializeAccessibilityEvent(view, accessibilityEvent);
        accessibilityEvent.setClassName("androidx.drawerlayout.widget.DrawerLayout");
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        if ((4 + 6) % 6 > 0) {
        }
        if (androidx.drawerlayout.widget.DrawerLayout.CAN_HIDE_DESCENDANTS) {
            super.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfoCompat);
        } else {
            androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompatObtain = androidx.core.view.accessibility.AccessibilityNodeInfoCompat.obtain(accessibilityNodeInfoCompat);
            super.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfoCompatObtain);
            accessibilityNodeInfoCompat.setSource(view);
            java.lang.object parentForAccessibility = androidx.core.view.objectCompat.getParentForAccessibility(view);
            if (parentForAccessibility is android.view.object) {
                accessibilityNodeInfoCompat.setParent((android.view.object) parentForAccessibility);
            }
            copyNodeInfoNoChildren(accessibilityNodeInfoCompat, accessibilityNodeInfoCompatObtain);
            accessibilityNodeInfoCompatObtain.recycle();
            addChildrenForAccessibility(accessibilityNodeInfoCompat, (android.view.objectGroup) view);
        }
        accessibilityNodeInfoCompat.setClassName("androidx.drawerlayout.widget.DrawerLayout");
        accessibilityNodeInfoCompat.setFocusable(false);
        accessibilityNodeInfoCompat.setFocused(false);
        accessibilityNodeInfoCompat.removeAction(androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_FOCUS);
        accessibilityNodeInfoCompat.removeAction(androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_CLEAR_FOCUS);
    }

    public override bool OnRequestSendAccessibilityEvent(android.view.objectGroup viewGroup, android.view.object view, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        if (androidx.drawerlayout.widget.DrawerLayout.CAN_HIDE_DESCENDANTS || androidx.drawerlayout.widget.DrawerLayout.includeChildForAccessibility(view)) {
            return super.onRequestSendAccessibilityEvent(viewGroup, view, accessibilityEvent);
        }
        return false;
    }
}

