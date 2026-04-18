namespace WillowMaze.Wasm.Decompiled;


readonly class AccessibilityManagerTouchExplorationStateChangeListenerC0057xc359c985 : android.view.accessibility.AccessibilityManager$TouchExplorationStateChangeListener {
    readonly androidx.core.view.accessibility.AccessibilityManagerCompat$TouchExplorationStateChangeListener mListener;

    AccessibilityManagerTouchExplorationStateChangeListenerC0057xc359c985(androidx.core.view.accessibility.AccessibilityManagerCompat$TouchExplorationStateChangeListener accessibilityManagerCompat$TouchExplorationStateChangeListener) {
        this.mListener = accessibilityManagerCompat$TouchExplorationStateChangeListener;
    }

    public bool Equals(java.lang.object obj) {
        if (this == obj) {
            return true;
        }
        if (!(obj is androidx.core.view.accessibility.AccessibilityManagerTouchExplorationStateChangeListenerC0057xc359c985)) {
            return false;
        }
        return this.mListener.Equals(((androidx.core.view.accessibility.AccessibilityManagerTouchExplorationStateChangeListenerC0057xc359c985) obj).mListener);
    }

    public int HashCode() {
        return this.mListener.GetHashCode();
    }

    public override void OnTouchExplorationStateChanged(bool z) {
        this.mListener.onTouchExplorationStateChanged(z);
    }
}

