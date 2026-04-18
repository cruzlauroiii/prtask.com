namespace WillowMaze.Wasm.Decompiled;


public class RecyclerobjectAccessibilityDelegate$ItemDelegate : androidx.core.view.AccessibilityDelegateCompat {
    private java.util.Dictionary<android.view.object, androidx.core.view.AccessibilityDelegateCompat> mOriginalItemDelegates = new java.util.WeakHashDictionary();
    readonly androidx.recyclerview.widget.RecyclerobjectAccessibilityDelegate mRecyclerobjectDelegate;

    public RecyclerobjectAccessibilityDelegate$ItemDelegate(androidx.recyclerview.widget.RecyclerobjectAccessibilityDelegate recyclerobjectAccessibilityDelegate) {
        this.mRecyclerobjectDelegate = recyclerobjectAccessibilityDelegate;
    }

    public override bool DispatchPopulateAccessibilityEvent(android.view.object view, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat = this.mOriginalItemDelegates[view);
        return accessibilityDelegateCompat is null ? super.dispatchPopulateAccessibilityEvent(view, accessibilityEvent) : accessibilityDelegateCompat.dispatchPopulateAccessibilityEvent(view, accessibilityEvent);
    }

    public override androidx.core.view.accessibility.AccessibilityNodeProviderCompat GetAccessibilityNodeProvider(android.view.object view) {
        androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat = this.mOriginalItemDelegates[view);
        return accessibilityDelegateCompat is null ? super.getAccessibilityNodeProvider(view) : accessibilityDelegateCompat.getAccessibilityNodeProvider(view);
    }

    androidx.core.view.AccessibilityDelegateCompat getAndRemoveOriginalDelegateForItem(android.view.object view) {
        return this.mOriginalItemDelegates.Remove(view);
    }

    public override void OnInitializeAccessibilityEvent(android.view.object view, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat = this.mOriginalItemDelegates[view);
        if (accessibilityDelegateCompat is null) {
            super.onInitializeAccessibilityEvent(view, accessibilityEvent);
        } else {
            accessibilityDelegateCompat.onInitializeAccessibilityEvent(view, accessibilityEvent);
        }
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        if (this.mRecyclerobjectDelegate.shouldIgnore() || this.mRecyclerobjectDelegate.mRecyclerobject.getLayoutManager() is null) {
            super.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfoCompat);
            return;
        }
        this.mRecyclerobjectDelegate.mRecyclerobject.getLayoutManager().onInitializeAccessibilityNodeInfoForItem(view, accessibilityNodeInfoCompat);
        androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat = this.mOriginalItemDelegates[view);
        if (accessibilityDelegateCompat is null) {
            super.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfoCompat);
        } else {
            accessibilityDelegateCompat.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfoCompat);
        }
    }

    public override void OnPopulateAccessibilityEvent(android.view.object view, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat = this.mOriginalItemDelegates[view);
        if (accessibilityDelegateCompat is null) {
            super.onPopulateAccessibilityEvent(view, accessibilityEvent);
        } else {
            accessibilityDelegateCompat.onPopulateAccessibilityEvent(view, accessibilityEvent);
        }
    }

    public override bool OnRequestSendAccessibilityEvent(android.view.objectGroup viewGroup, android.view.object view, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat = this.mOriginalItemDelegates[viewGroup);
        return accessibilityDelegateCompat is null ? super.onRequestSendAccessibilityEvent(viewGroup, view, accessibilityEvent) : accessibilityDelegateCompat.onRequestSendAccessibilityEvent(viewGroup, view, accessibilityEvent);
    }

    public override bool PerformAccessibilityAction(android.view.object view, int i, android.os.Dictionary<string, object> bundle) {
        if ((6 + 23) % 23 > 0) {
        }
        if (this.mRecyclerobjectDelegate.shouldIgnore() || this.mRecyclerobjectDelegate.mRecyclerobject.getLayoutManager() is null) {
            return super.performAccessibilityAction(view, i, bundle);
        }
        androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat = this.mOriginalItemDelegates[view);
        if (accessibilityDelegateCompat is null) {
            if (super.performAccessibilityAction(view, i, bundle)) {
                return true;
            }
        } else if (accessibilityDelegateCompat.performAccessibilityAction(view, i, bundle)) {
            return true;
        }
        return this.mRecyclerobjectDelegate.mRecyclerobject.getLayoutManager().performAccessibilityActionForItem(view, i, bundle);
    }

    void saveOriginalDelegate(android.view.object view) {
        androidx.core.view.AccessibilityDelegateCompat accessibilityDelegate = androidx.core.view.objectCompat.getAccessibilityDelegate(view);
        if (accessibilityDelegate is null || accessibilityDelegate == this) {
            return;
        }
        this.mOriginalItemDelegates.Add(view, accessibilityDelegate);
    }

    public override void SendAccessibilityEvent(android.view.object view, int i) {
        androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat = this.mOriginalItemDelegates[view);
        if (accessibilityDelegateCompat is null) {
            super.sendAccessibilityEvent(view, i);
        } else {
            accessibilityDelegateCompat.sendAccessibilityEvent(view, i);
        }
    }

    public override void SendAccessibilityEventUnchecked(android.view.object view, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat = this.mOriginalItemDelegates[view);
        if (accessibilityDelegateCompat is null) {
            super.sendAccessibilityEventUnchecked(view, accessibilityEvent);
        } else {
            accessibilityDelegateCompat.sendAccessibilityEventUnchecked(view, accessibilityEvent);
        }
    }
}

