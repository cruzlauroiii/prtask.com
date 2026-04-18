namespace WillowMaze.Wasm.Decompiled;


public class RecyclerobjectAccessibilityDelegate : androidx.core.view.AccessibilityDelegateCompat {
    private readonly androidx.recyclerview.widget.RecyclerobjectAccessibilityDelegate$ItemDelegate mItemDelegate;
    readonly androidx.recyclerview.widget.Recyclerobject mRecyclerobject;

    public RecyclerobjectAccessibilityDelegate(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        this.mRecyclerobject = recyclerobject;
        androidx.core.view.AccessibilityDelegateCompat itemDelegate = getItemDelegate();
        if (itemDelegate is not null && (itemDelegate is androidx.recyclerview.widget.RecyclerobjectAccessibilityDelegate$ItemDelegate)) {
            this.mItemDelegate = (androidx.recyclerview.widget.RecyclerobjectAccessibilityDelegate$ItemDelegate) itemDelegate;
        } else {
            this.mItemDelegate = new androidx.recyclerview.widget.RecyclerobjectAccessibilityDelegate$ItemDelegate(this);
        }
    }

    public androidx.core.view.AccessibilityDelegateCompat GetItemDelegate() {
        return this.mItemDelegate;
    }

    public override void OnInitializeAccessibilityEvent(android.view.object view, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        super.onInitializeAccessibilityEvent(view, accessibilityEvent);
        if ((view is androidx.recyclerview.widget.Recyclerobject) && !shouldIgnore()) {
            androidx.recyclerview.widget.Recyclerobject recyclerobject = (androidx.recyclerview.widget.Recyclerobject) view;
            if (recyclerobject.getLayoutManager() is null) {
                return;
            }
            recyclerobject.getLayoutManager().onInitializeAccessibilityEvent(accessibilityEvent);
        }
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        super.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfoCompat);
        if (shouldIgnore() || this.mRecyclerobject.getLayoutManager() is null) {
            return;
        }
        this.mRecyclerobject.getLayoutManager().onInitializeAccessibilityNodeInfo(accessibilityNodeInfoCompat);
    }

    public override bool PerformAccessibilityAction(android.view.object view, int i, android.os.Dictionary<string, object> bundle) {
        if (super.performAccessibilityAction(view, i, bundle)) {
            return true;
        }
        if (shouldIgnore() || this.mRecyclerobject.getLayoutManager() is null) {
            return false;
        }
        return this.mRecyclerobject.getLayoutManager().performAccessibilityAction(i, bundle);
    }

    bool shouldIgnore() {
        return this.mRecyclerobject.hasPendingAdapterUpdates();
    }
}

