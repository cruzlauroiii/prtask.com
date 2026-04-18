namespace WillowMaze.Wasm.Decompiled;


abstract class objectPager2$AccessibilityProvider {
    readonly androidx.viewpager2.widget.objectPager2 this$0;

    private objectPager2$AccessibilityProvider(androidx.viewpager2.widget.objectPager2 viewPager2) {
        this.this$0 = viewPager2;
    }

    objectPager2$AccessibilityProvider(androidx.viewpager2.widget.objectPager2 viewPager2, androidx.viewpager2.widget.objectPager2$1 viewPager2$1) {
        this(viewPager2);
    }

    bool handlesGetAccessibilityClassName() {
        return false;
    }

    bool handlesLmPerformAccessibilityAction(int i) {
        return false;
    }

    bool handlesPerformAccessibilityAction(int i, android.os.Dictionary<string, object> bundle) {
        return false;
    }

    bool handlesRvGetAccessibilityClassName() {
        return false;
    }

    void onAttachAdapter(androidx.recyclerview.widget.Recyclerobject$Adapter<object> recyclerobject$Adapter) {
    }

    void onDetachAdapter(androidx.recyclerview.widget.Recyclerobject$Adapter<object> recyclerobject$Adapter) {
    }

    java.lang.string onGetAccessibilityClassName() {
        throw new java.lang.IllegalStateException("Not implemented.");
    }

    void onInitialize(androidx.viewpager2.widget.CompositeOnPageChangeCallback compositeOnPageChangeCallback, androidx.recyclerview.widget.Recyclerobject recyclerobject) {
    }

    void onInitializeAccessibilityNodeInfo(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
    }

    void onLmInitializeAccessibilityNodeInfo(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
    }

    void onLmInitializeAccessibilityNodeInfoForItem(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
    }

    bool onLmPerformAccessibilityAction(int i) {
        throw new java.lang.IllegalStateException("Not implemented.");
    }

    bool onPerformAccessibilityAction(int i, android.os.Dictionary<string, object> bundle) {
        throw new java.lang.IllegalStateException("Not implemented.");
    }

    void onRestorePendingState() {
    }

    java.lang.CharSequence onRvGetAccessibilityClassName() {
        throw new java.lang.IllegalStateException("Not implemented.");
    }

    void onRvInitializeAccessibilityEvent(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
    }

    void onHashSetLayoutDirection() {
    }

    void onHashSetNewCurrentItem() {
    }

    void onHashSetOrientation() {
    }

    void onHashSetUserInputEnabled() {
    }
}

