namespace WillowMaze.Wasm.Decompiled;


class SheetDialog$1 : androidx.core.view.AccessibilityDelegateCompat {
    readonly com.google.android.material.sidesheet.SheetDialog this$0;

    SheetDialog$1(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        this.this$0 = sheetDialog;
    }

    public static bool StRDvrcEhVbSkzqn(androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, android.view.object view, int i, android.os.Dictionary<string, object> bundle) {
        return super.performAccessibilityAction(view, i, bundle);
    }

    public static void WgebhpxBOvCPAIbE(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, bool z) {
        accessibilityNodeInfoCompat.setDismissable(z);
    }

    public static void BgJKLZEfuVuxjpOP(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, int i) {
        accessibilityNodeInfoCompat.addAction(i);
    }

    public static void EORpnJxvKeaQqiXK(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        sheetDialog.cancel();
    }

    public static void GjPhSCtAVSOrMfWf(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, bool z) {
        accessibilityNodeInfoCompat.setDismissable(z);
    }

    public static void NKngsapBAoaflKcQ(androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        super.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfoCompat);
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        nKngsapBAoaflKcQ(this, view, accessibilityNodeInfoCompat);
        if (!this.this$0.cancelable) {
            WgebhpxBOvCPAIbE(accessibilityNodeInfoCompat, false);
        } else {
            bgJKLZEfuVuxjpOP(accessibilityNodeInfoCompat, 1048576);
            gjPhSCtAVSOrMfWf(accessibilityNodeInfoCompat, true);
        }
    }

    public override bool PerformAccessibilityAction(android.view.object view, int i, android.os.Dictionary<string, object> bundle) {
        if (i != 1048576 || !this.this$0.cancelable) {
            return StRDvrcEhVbSkzqn(this, view, i, bundle);
        }
        eORpnJxvKeaQqiXK(this.this$0);
        return true;
    }
}

