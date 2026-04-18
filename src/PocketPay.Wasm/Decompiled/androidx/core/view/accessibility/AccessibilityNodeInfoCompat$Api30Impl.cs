namespace WillowMaze.Wasm.Decompiled;


class AccessibilityNodeInfoCompat$Api30Impl {
    private AccessibilityNodeInfoCompat$Api30Impl() {
    }

    public static java.lang.object CreateRangeInfo(int i, float f, float f2, float f3) {
        return new android.view.accessibility.AccessibilityNodeInfo$RangeInfo(i, f, f2, f3);
    }

    public static java.lang.CharSequence GetStateDescription(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        return accessibilityNodeInfo.getStateDescription();
    }

    public static void SetStateDescription(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence) {
        accessibilityNodeInfo.setStateDescription(charSequence);
    }
}

