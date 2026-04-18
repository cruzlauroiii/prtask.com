namespace WillowMaze.Wasm.Decompiled;


class objectChooserobject$3 : android.view.object$AccessibilityDelegate {
    readonly androidx.appcompat.widget.objectChooserobject this$0;

    objectChooserobject$3(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        this.this$0 = activityChooserobject;
    }

    public static void IGEaBwHCHFnLTNSz(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, bool z) {
        accessibilityNodeInfoCompat.setCanOpenPopup(z);
    }

    public static void IpltIoyenBgIpdmT(android.view.object$AccessibilityDelegate view$AccessibilityDelegate, android.view.object view, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        super.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfo);
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat TniDACtFsvsGHOfb(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat.wrap(accessibilityNodeInfo);
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.object view, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        ipltIoyenBgIpdmT(this, view, accessibilityNodeInfo);
        iGEaBwHCHFnLTNSz(tniDACtFsvsGHOfb(accessibilityNodeInfo), true);
    }
}

