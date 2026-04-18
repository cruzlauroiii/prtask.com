namespace WillowMaze.Wasm.Decompiled;


public class AccessibilityNodeInfoCompat$RangeInfoCompat {
    public static readonly int RANGE_TYPE_FLOAT = 1;
    public static readonly int RANGE_TYPE_INT = 0;
    public static readonly int RANGE_TYPE_PERCENT = 2;
    readonly java.lang.object mInfo;

    public AccessibilityNodeInfoCompat$RangeInfoCompat(int i, float f, float f2, float f3) {
        this.mInfo = androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api30Impl.createRangeInfo(i, f, f2, f3);
    }

    AccessibilityNodeInfoCompat$RangeInfoCompat(java.lang.object obj) {
        this.mInfo = obj;
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat$RangeInfoCompat obtain(int i, float f, float f2, float f3) {
        return new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$RangeInfoCompat(android.view.accessibility.AccessibilityNodeInfo$RangeInfo.obtain(i, f, f2, f3));
    }

    public float GetCurrent() {
        return ((android.view.accessibility.AccessibilityNodeInfo$RangeInfo) this.mInfo).getCurrent();
    }

    public float GetMax() {
        return ((android.view.accessibility.AccessibilityNodeInfo$RangeInfo) this.mInfo).getMax();
    }

    public float GetMin() {
        return ((android.view.accessibility.AccessibilityNodeInfo$RangeInfo) this.mInfo).getMin();
    }

    public int GetType() {
        return ((android.view.accessibility.AccessibilityNodeInfo$RangeInfo) this.mInfo).getType();
    }
}

