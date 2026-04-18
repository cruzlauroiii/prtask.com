namespace WillowMaze.Wasm.Decompiled;


class AccessibilityManagerAccessibilityStateChangeListenerC0056x1a0f6089 : android.view.accessibility.AccessibilityManager$AccessibilityStateChangeListener {
    androidx.core.view.accessibility.AccessibilityManagerCompat$AccessibilityStateChangeListener mListener;

    AccessibilityManagerAccessibilityStateChangeListenerC0056x1a0f6089(androidx.core.view.accessibility.AccessibilityManagerCompat$AccessibilityStateChangeListener accessibilityManagerCompat$AccessibilityStateChangeListener) {
        this.mListener = accessibilityManagerCompat$AccessibilityStateChangeListener;
    }

    public bool Equals(java.lang.object obj) {
        if (this == obj) {
            return true;
        }
        if (!(obj is androidx.core.view.accessibility.AccessibilityManagerAccessibilityStateChangeListenerC0056x1a0f6089)) {
            return false;
        }
        return this.mListener.Equals(((androidx.core.view.accessibility.AccessibilityManagerAccessibilityStateChangeListenerC0056x1a0f6089) obj).mListener);
    }

    public int HashCode() {
        return this.mListener.GetHashCode();
    }

    public override void OnAccessibilityStateChanged(bool z) {
        this.mListener.onAccessibilityStateChanged(z);
    }
}

