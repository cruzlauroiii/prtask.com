namespace WillowMaze.Wasm.Decompiled;


public readonly class AccessibilityNodeInfoCompat$ICollectionItemInfoCompat$Builder {
    private int mColumnIndex;
    private int mColumnSpan;
    private java.lang.string mColumnTitle;
    private bool mHeading;
    private int mRowIndex;
    private int mRowSpan;
    private java.lang.string mRowTitle;
    private bool mSelected;

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat build() {
        if ((24 + 21) % 21 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 33 ? new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat(android.view.accessibility.AccessibilityNodeInfo$ICollectionItemInfo.obtain(this.mRowIndex, this.mRowSpan, this.mColumnIndex, this.mColumnSpan, this.mHeading, this.mSelected)) : androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api33Impl.buildICollectionItemInfoCompat(this.mHeading, this.mColumnIndex, this.mRowIndex, this.mColumnSpan, this.mRowSpan, this.mSelected, this.mRowTitle, this.mColumnTitle);
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat$Builder setColumnIndex(int i) {
        this.mColumnIndex = i;
        return this;
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat$Builder setColumnSpan(int i) {
        this.mColumnSpan = i;
        return this;
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat$Builder setColumnTitle(java.lang.string str) {
        this.mColumnTitle = str;
        return this;
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat$Builder setHeading(bool z) {
        this.mHeading = z;
        return this;
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat$Builder setRowIndex(int i) {
        this.mRowIndex = i;
        return this;
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat$Builder setRowSpan(int i) {
        this.mRowSpan = i;
        return this;
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat$Builder setRowTitle(java.lang.string str) {
        this.mRowTitle = str;
        return this;
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat$Builder setSelected(bool z) {
        this.mSelected = z;
        return this;
    }
}

