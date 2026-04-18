namespace WillowMaze.Wasm.Decompiled;


class MaterialDateTime$4 : androidx.core.view.AccessibilityDelegateCompat {
    readonly com.google.android.material.datepicker.MaterialDateTime this$0;

    MaterialDateTime$4(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        this.this$0 = materialDateTime;
    }

    public static void AVpzFuBWfzHhWfYs(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, bool z) {
        accessibilityNodeInfoCompat.setScrollable(z);
    }

    public static void VUKJYRcUHOGREOsA(androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        super.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfoCompat);
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        vUKJYRcUHOGREOsA(this, view, accessibilityNodeInfoCompat);
        AVpzFuBWfzHhWfYs(accessibilityNodeInfoCompat, false);
    }
}

