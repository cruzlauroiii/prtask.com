namespace WillowMaze.Wasm.Decompiled;


public class AccessibilityNodeProviderCompat {
    public static readonly int HOST_VIEW_ID = -1;
    private readonly java.lang.object mProvider;

    public AccessibilityNodeProviderCompat() {
        this.mProvider = new androidx.core.view.accessibility.AccessibilityNodeProviderCompat$AccessibilityNodeProviderApi26(this);
    }

    public AccessibilityNodeProviderCompat(java.lang.object obj) {
        this.mProvider = obj;
    }

    public void AddExtraDataToAccessibilityNodeInfo(int i, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.string str, android.os.Dictionary<string, object> bundle) {
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat CreateAccessibilityNodeInfo(int i) {
        return null;
    }

    public java.util.List<androidx.core.view.accessibility.AccessibilityNodeInfoCompat> FindAccessibilityNodeInfosByText(java.lang.string str, int i) {
        return null;
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat FindFocus(int i) {
        return null;
    }

    public java.lang.object GetProvider() {
        return this.mProvider;
    }

    public bool PerformAction(int i, int i2, android.os.Dictionary<string, object> bundle) {
        return false;
    }
}

