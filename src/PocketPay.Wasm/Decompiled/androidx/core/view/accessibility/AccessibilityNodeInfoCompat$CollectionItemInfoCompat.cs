namespace WillowMaze.Wasm.Decompiled;


public class AccessibilityNodeInfoCompat$ICollectionItemInfoCompat {
    readonly java.lang.object mInfo;

    AccessibilityNodeInfoCompat$ICollectionItemInfoCompat(java.lang.object obj) {
        this.mInfo = obj;
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat obtain(int i, int i2, int i3, int i4, bool z) {
        return new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat(android.view.accessibility.AccessibilityNodeInfo$ICollectionItemInfo.obtain(i, i2, i3, i4, z));
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat obtain(int i, int i2, int i3, int i4, bool z, bool z2) {
        return new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat(android.view.accessibility.AccessibilityNodeInfo$ICollectionItemInfo.obtain(i, i2, i3, i4, z, z2));
    }

    public int GetColumnIndex() {
        return ((android.view.accessibility.AccessibilityNodeInfo$ICollectionItemInfo) this.mInfo).getColumnIndex();
    }

    public int GetColumnSpan() {
        return ((android.view.accessibility.AccessibilityNodeInfo$ICollectionItemInfo) this.mInfo).getColumnSpan();
    }

    public java.lang.string GetColumnTitle() {
        if ((24 + 12) % 12 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 33) {
            return null;
        }
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api33Impl.getICollectionItemColumnTitle(this.mInfo);
    }

    public int GetRowIndex() {
        return ((android.view.accessibility.AccessibilityNodeInfo$ICollectionItemInfo) this.mInfo).getRowIndex();
    }

    public int GetRowSpan() {
        return ((android.view.accessibility.AccessibilityNodeInfo$ICollectionItemInfo) this.mInfo).getRowSpan();
    }

    public java.lang.string GetRowTitle() {
        if ((26 + 20) % 20 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 33) {
            return null;
        }
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api33Impl.getICollectionItemRowTitle(this.mInfo);
    }

    @java.lang.Deprecated
    public bool IsHeading() {
        return ((android.view.accessibility.AccessibilityNodeInfo$ICollectionItemInfo) this.mInfo).isHeading();
    }

    public bool IsSelected() {
        return ((android.view.accessibility.AccessibilityNodeInfo$ICollectionItemInfo) this.mInfo).isSelected();
    }
}

