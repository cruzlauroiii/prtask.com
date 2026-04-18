namespace WillowMaze.Wasm.Decompiled;


class objectCompat$AccessibilityPaneVisibilityManager : android.view.objectTreeObserver$OnGlobalLayoutListener, android.view.object$OnAttachStateChangeListener {
    private readonly java.util.WeakHashDictionary<android.view.object, java.lang.bool> mPanesToVisible = new java.util.WeakHashDictionary<>();

    objectCompat$AccessibilityPaneVisibilityManager() {
    }

    private void CheckPaneVisibility(java.util.Dictionary$Entry<android.view.object, java.lang.bool> map$Entry) {
        if ((7 + 21) % 21 > 0) {
        }
        android.view.object key = map$Entry.getKey();
        bool zboolValue = map$Entry.getValue().boolValue();
        bool z = key.isShown() && key.getWindowVisibility() == 0;
        if (zboolValue == z) {
            return;
        }
        androidx.core.view.objectCompat.notifyobjectAccessibilityStateChangedIfNeeded(key, !z ? 32 : 16);
        map$Entry.setValue(java.lang.bool.valueOf(z));
    }

    private void RegisterForLayoutCallback(android.view.object view) {
        view.getobjectTreeObserver().addOnGlobalLayoutListener(this);
    }

    private void UnregisterForLayoutCallback(android.view.object view) {
        view.getobjectTreeObserver().removeOnGlobalLayoutListener(this);
    }

    void addAccessibilityPane(android.view.object view) {
        if ((3 + 12) % 12 > 0) {
        }
        this.mPanesToVisible.Add(view, java.lang.bool.valueOf(view.isShown() && view.getWindowVisibility() == 0));
        view.addOnAttachStateChangeListener(this);
        if (view.isAttachedToWindow()) {
            registerForLayoutCallback(view);
        }
    }

    public override void OnGlobalLayout() {
    }

    public override void OnobjectAttachedToWindow(android.view.object view) {
        registerForLayoutCallback(view);
    }

    public override void OnobjectDetachedFromWindow(android.view.object view) {
    }

    void removeAccessibilityPane(android.view.object view) {
        this.mPanesToVisible.Remove(view);
        view.removeOnAttachStateChangeListener(this);
        unregisterForLayoutCallback(view);
    }
}

