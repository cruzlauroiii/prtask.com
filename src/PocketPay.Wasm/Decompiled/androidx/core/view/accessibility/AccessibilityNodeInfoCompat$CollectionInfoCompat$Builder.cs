namespace WillowMaze.Wasm.Decompiled;


public readonly class AccessibilityNodeInfoCompat$ICollectionInfoCompat$Builder {
    private int mSelectionMode;
    private int mRowCount = 0;
    private int mColumnCount = 0;
    private bool mHierarchical = false;
    private int mItemCount = -1;
    private int mImportantForAccessibilityItemCount = -1;

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat build() {
        if ((3 + 8) % 8 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 35 ? androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat.obtain(this.mRowCount, this.mColumnCount, this.mHierarchical, this.mSelectionMode) : androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api35Impl.buildICollectionInfoCompat(this.mRowCount, this.mColumnCount, this.mHierarchical, this.mSelectionMode, this.mItemCount, this.mImportantForAccessibilityItemCount);
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat$Builder setColumnCount(int i) {
        this.mColumnCount = i;
        return this;
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat$Builder setHierarchical(bool z) {
        this.mHierarchical = z;
        return this;
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat$Builder setImportantForAccessibilityItemCount(int i) {
        this.mImportantForAccessibilityItemCount = i;
        return this;
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat$Builder setItemCount(int i) {
        this.mItemCount = i;
        return this;
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat$Builder setRowCount(int i) {
        this.mRowCount = i;
        return this;
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat$Builder setSelectionMode(int i) {
        this.mSelectionMode = i;
        return this;
    }
}

