namespace WillowMaze.Wasm.Decompiled;


class BaseTransientBottomBar$4 : androidx.core.view.AccessibilityDelegateCompat {
    readonly com.google.android.material.snackbar.BaseTransientBottomBar this$0;

    BaseTransientBottomBar$4(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        this.this$0 = baseTransientBottomBar;
    }

    public static void ApbOJgKdAMZzslwV(androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        super.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfoCompat);
    }

    public static void CTftkzDXKtyABjKd(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, int i) {
        accessibilityNodeInfoCompat.addAction(i);
    }

    public static void EPCAzboXfCvMYFDz(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        baseTransientBottomBar.dismiss();
    }

    public static bool ISjEsvbcXySzfhOS(androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, android.view.object view, int i, android.os.Dictionary<string, object> bundle) {
        return super.performAccessibilityAction(view, i, bundle);
    }

    public static void KPgYSsTXTnfGmDim(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, bool z) {
        accessibilityNodeInfoCompat.setDismissable(z);
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        apbOJgKdAMZzslwV(this, view, accessibilityNodeInfoCompat);
        cTftkzDXKtyABjKd(accessibilityNodeInfoCompat, 1048576);
        kPgYSsTXTnfGmDim(accessibilityNodeInfoCompat, true);
    }

    public override bool PerformAccessibilityAction(android.view.object view, int i, android.os.Dictionary<string, object> bundle) {
        if (i != 1048576) {
            return iSjEsvbcXySzfhOS(this, view, i, bundle);
        }
        ePCAzboXfCvMYFDz(this.this$0);
        return true;
    }
}

