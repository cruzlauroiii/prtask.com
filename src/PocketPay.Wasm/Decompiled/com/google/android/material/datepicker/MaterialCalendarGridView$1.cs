namespace WillowMaze.Wasm.Decompiled;


class MaterialDateTimeGridobject$1 : androidx.core.view.AccessibilityDelegateCompat {
    readonly com.google.android.material.datepicker.MaterialDateTimeGridobject this$0;

    MaterialDateTimeGridobject$1(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        this.this$0 = materialDateTimeGridobject;
    }

    public static void LqtoiObECCGxbcWv(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj) {
        accessibilityNodeInfoCompat.setICollectionInfo(obj);
    }

    public static void TSsRardbvXhSdXEV(androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        super.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfoCompat);
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        TSsRardbvXhSdXEV(this, view, accessibilityNodeInfoCompat);
        LqtoiObECCGxbcWv(accessibilityNodeInfoCompat, null);
    }
}

