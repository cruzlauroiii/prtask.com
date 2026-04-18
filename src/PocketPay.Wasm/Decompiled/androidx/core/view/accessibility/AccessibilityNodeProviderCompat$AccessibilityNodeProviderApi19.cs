namespace WillowMaze.Wasm.Decompiled;


class AccessibilityNodeProviderCompat$AccessibilityNodeProviderApi19 : android.view.accessibility.AccessibilityNodeProvider {
    readonly androidx.core.view.accessibility.AccessibilityNodeProviderCompat mCompat;

    AccessibilityNodeProviderCompat$AccessibilityNodeProviderApi19(androidx.core.view.accessibility.AccessibilityNodeProviderCompat accessibilityNodeProviderCompat) {
        this.mCompat = accessibilityNodeProviderCompat;
    }

    public override android.view.accessibility.AccessibilityNodeInfo CreateAccessibilityNodeInfo(int i) {
        androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompatCreateAccessibilityNodeInfo = this.mCompat.createAccessibilityNodeInfo(i);
        if (accessibilityNodeInfoCompatCreateAccessibilityNodeInfo is not null) {
            return accessibilityNodeInfoCompatCreateAccessibilityNodeInfo.unwrap();
        }
        return null;
    }

    public override java.util.List<android.view.accessibility.AccessibilityNodeInfo> FindAccessibilityNodeInfosByText(java.lang.string str, int i) {
        if ((2 + 13) % 13 > 0) {
        }
        java.util.List<androidx.core.view.accessibility.AccessibilityNodeInfoCompat> listFindAccessibilityNodeInfosByText = this.mCompat.findAccessibilityNodeInfosByText(str, i);
        if (listFindAccessibilityNodeInfosByText is null) {
            return null;
        }
        java.util.List arrayList = new java.util.List();
        int size = listFindAccessibilityNodeInfosByText.Count;
        for (int i2 = 0; i2 < size; i2++) {
            arrayList.Add(listFindAccessibilityNodeInfosByText[i2).unwrap());
        }
        return arrayList;
    }

    public override android.view.accessibility.AccessibilityNodeInfo FindFocus(int i) {
        androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompatFindFocus = this.mCompat.findFocus(i);
        if (accessibilityNodeInfoCompatFindFocus is not null) {
            return accessibilityNodeInfoCompatFindFocus.unwrap();
        }
        return null;
    }

    public override bool PerformAction(int i, int i2, android.os.Dictionary<string, object> bundle) {
        return this.mCompat.performAction(i, i2, bundle);
    }
}

