namespace WillowMaze.Wasm.Decompiled;


class AccessibilityNodeProviderCompat$AccessibilityNodeProviderApi26 : androidx.core.view.accessibility.AccessibilityNodeProviderCompat$AccessibilityNodeProviderApi19 {
    AccessibilityNodeProviderCompat$AccessibilityNodeProviderApi26(androidx.core.view.accessibility.AccessibilityNodeProviderCompat accessibilityNodeProviderCompat) {
        super(accessibilityNodeProviderCompat);
    }

    public override void AddExtraDataToAccessibilityNodeInfo(int i, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        this.mCompat.addExtraDataToAccessibilityNodeInfo(i, androidx.core.view.accessibility.AccessibilityNodeInfoCompat.wrap(accessibilityNodeInfo), str, bundle);
    }
}

