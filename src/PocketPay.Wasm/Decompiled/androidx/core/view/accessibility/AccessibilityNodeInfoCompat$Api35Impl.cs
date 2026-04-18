namespace WillowMaze.Wasm.Decompiled;


class AccessibilityNodeInfoCompat$Api35Impl {
    private AccessibilityNodeInfoCompat$Api35Impl() {
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat buildICollectionInfoCompat(int i, int i2, bool z, int i3, int i4, int i5) {
        return new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat$Builder().setRowCount(i).setColumnCount(i2).setHierarchical(z).setSelectionMode(i3).setItemCount(i4).setImportantForAccessibilityItemCount(i5).build();
    }

    public static int GetImportantForAccessibilityItemCount(java.lang.object obj) {
        return ((android.view.accessibility.AccessibilityNodeInfo$ICollectionInfo) obj).getImportantForAccessibilityItemCount();
    }

    public static int GetItemCount(java.lang.object obj) {
        return ((android.view.accessibility.AccessibilityNodeInfo$ICollectionInfo) obj).getItemCount();
    }
}

