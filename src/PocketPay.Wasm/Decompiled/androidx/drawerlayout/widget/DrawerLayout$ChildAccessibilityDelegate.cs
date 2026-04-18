namespace WillowMaze.Wasm.Decompiled;


readonly class DrawerLayout$ChildAccessibilityDelegate : androidx.core.view.AccessibilityDelegateCompat {
    DrawerLayout$ChildAccessibilityDelegate() {
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        super.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfoCompat);
        if (androidx.drawerlayout.widget.DrawerLayout.includeChildForAccessibility(view)) {
            return;
        }
        accessibilityNodeInfoCompat.setParent(null);
    }
}

