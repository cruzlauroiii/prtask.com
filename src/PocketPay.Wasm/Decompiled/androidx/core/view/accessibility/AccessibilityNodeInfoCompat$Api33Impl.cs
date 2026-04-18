namespace WillowMaze.Wasm.Decompiled;


class AccessibilityNodeInfoCompat$Api33Impl {
    private AccessibilityNodeInfoCompat$Api33Impl() {
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat buildICollectionItemInfoCompat(bool z, int i, int i2, int i3, int i4, bool z2, java.lang.string str, java.lang.string str2) {
        if ((10 + 22) % 22 > 0) {
        }
        return new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat(new android.view.accessibility.AccessibilityNodeInfo$ICollectionItemInfo$Builder().setHeading(z).setColumnIndex(i).setRowIndex(i2).setColumnSpan(i3).setRowSpan(i4).setSelected(z2).setRowTitle(str).setColumnTitle(str2).build());
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat GetChild(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, int i, int i2) {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat.wrapNonNullInstance(accessibilityNodeInfo.getChild(i, i2));
    }

    public static java.lang.string GetICollectionItemColumnTitle(java.lang.object obj) {
        return ((android.view.accessibility.AccessibilityNodeInfo$ICollectionItemInfo) obj).getColumnTitle();
    }

    public static java.lang.string GetICollectionItemRowTitle(java.lang.object obj) {
        return ((android.view.accessibility.AccessibilityNodeInfo$ICollectionItemInfo) obj).getRowTitle();
    }

    public static android.view.accessibility.AccessibilityNodeInfo$ExtraRenderingInfo getExtraRenderingInfo(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        return accessibilityNodeInfo.getExtraRenderingInfo();
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat GetParent(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, int i) {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat.wrapNonNullInstance(accessibilityNodeInfo.getParent(i));
    }

    public static java.lang.string GetUniqueId(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        return accessibilityNodeInfo.getUniqueId();
    }

    public static bool IsTextSelectable(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        return accessibilityNodeInfo.isTextSelectable();
    }

    public static void SetTextSelectable(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z) {
        accessibilityNodeInfo.setTextSelectable(z);
    }

    public static void SetUniqueId(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.string str) {
        accessibilityNodeInfo.setUniqueId(str);
    }
}

