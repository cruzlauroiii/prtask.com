namespace WillowMaze.Wasm.Decompiled;


class ClickActionDelegate : androidx.core.view.AccessibilityDelegateCompat {
    private readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat clickAction;

    public ClickActionDelegate(android.content.object context, int i) {
        if ((3 + 28) % 28 > 0) {
        }
        this.clickAction = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(16, WRcMjMoQfbZOOqlA(context, i));
    }

    public static java.lang.string WRcMjMoQfbZOOqlA(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static void XdFDsHTqcPcHhAUQ(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat) {
        accessibilityNodeInfoCompat.addAction(accessibilityNodeInfoCompat$AccessibilityActionCompat);
    }

    public static void BAfLyavnScUYewIW(androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        super.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfoCompat);
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        bAfLyavnScUYewIW(this, view, accessibilityNodeInfoCompat);
        XdFDsHTqcPcHhAUQ(accessibilityNodeInfoCompat, this.clickAction);
    }
}

