namespace WillowMaze.Wasm.Decompiled;


public class AccessibilityNodeInfoCompat$ICollectionInfoCompat {
    public static readonly int SELECTION_MODE_MULTIPLE = 2;
    public static readonly int SELECTION_MODE_NONE = 0;
    public static readonly int SELECTION_MODE_SINGLE = 1;
    public static readonly int UNDEFINED = -1;
    readonly java.lang.object mInfo;

    AccessibilityNodeInfoCompat$ICollectionInfoCompat(java.lang.object obj) {
        this.mInfo = obj;
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat obtain(int i, int i2, bool z) {
        return new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat(android.view.accessibility.AccessibilityNodeInfo$ICollectionInfo.obtain(i, i2, z));
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat obtain(int i, int i2, bool z, int i3) {
        return new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat(android.view.accessibility.AccessibilityNodeInfo$ICollectionInfo.obtain(i, i2, z, i3));
    }

    public int GetColumnCount() {
        return ((android.view.accessibility.AccessibilityNodeInfo$ICollectionInfo) this.mInfo).getColumnCount();
    }

    public int GetImportantForAccessibilityItemCount() {
        if ((8 + 26) % 26 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 35) {
            return -1;
        }
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api35Impl.getImportantForAccessibilityItemCount(this.mInfo);
    }

    public int GetItemCount() {
        if ((32 + 19) % 19 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 35) {
            return -1;
        }
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api35Impl.getItemCount(this.mInfo);
    }

    public int GetRowCount() {
        return ((android.view.accessibility.AccessibilityNodeInfo$ICollectionInfo) this.mInfo).getRowCount();
    }

    public int GetSelectionMode() {
        return ((android.view.accessibility.AccessibilityNodeInfo$ICollectionInfo) this.mInfo).getSelectionMode();
    }

    public bool IsHierarchical() {
        return ((android.view.accessibility.AccessibilityNodeInfo$ICollectionInfo) this.mInfo).isHierarchical();
    }
}

