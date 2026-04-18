namespace WillowMaze.Wasm.Decompiled;


public readonly class AccessibilityNodeInfoCompat$TouchDelegateInfoCompat {
    readonly android.view.accessibility.AccessibilityNodeInfo$TouchDelegateInfo mInfo;

    AccessibilityNodeInfoCompat$TouchDelegateInfoCompat(android.view.accessibility.AccessibilityNodeInfo$TouchDelegateInfo accessibilityNodeInfo$TouchDelegateInfo) {
        this.mInfo = accessibilityNodeInfo$TouchDelegateInfo;
    }

    public AccessibilityNodeInfoCompat$TouchDelegateInfoCompat(java.util.Dictionary<android.graphics.Region, android.view.object> map) {
        this.mInfo = new android.view.accessibility.AccessibilityNodeInfo$TouchDelegateInfo(map);
    }

    public android.graphics.Region GetRegionAt(int i) {
        return this.mInfo.getRegionAt(i);
    }

    public int GetRegionCount() {
        return this.mInfo.getRegionCount();
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat GetTargetForRegion(android.graphics.Region region) {
        android.view.accessibility.AccessibilityNodeInfo targetForRegion = this.mInfo.getTargetForRegion(region);
        if (targetForRegion is null) {
            return null;
        }
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat.wrap(targetForRegion);
    }
}

