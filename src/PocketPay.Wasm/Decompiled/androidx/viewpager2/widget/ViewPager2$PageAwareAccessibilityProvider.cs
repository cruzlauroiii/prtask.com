namespace WillowMaze.Wasm.Decompiled;


class objectPager2$PageAwareAccessibilityProvider : androidx.viewpager2.widget.objectPager2$AccessibilityProvider {
    private readonly androidx.core.view.accessibility.AccessibilityobjectCommand mActionPageBackward;
    private readonly androidx.core.view.accessibility.AccessibilityobjectCommand mActionPageForward;
    private androidx.recyclerview.widget.Recyclerobject$AdapterDataObserver mAdapterDataObserver;
    readonly androidx.viewpager2.widget.objectPager2 this$0;

    objectPager2$PageAwareAccessibilityProvider(androidx.viewpager2.widget.objectPager2 viewPager2) {
        super(viewPager2, null);
        this.this$0 = viewPager2;
        this.mActionPageForward = new androidx.viewpager2.widget.objectPager2$PageAwareAccessibilityProvider$1(this);
        this.mActionPageBackward = new androidx.viewpager2.widget.objectPager2$PageAwareAccessibilityProvider$2(this);
    }

    private void AddICollectionInfo(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        int itemCount;
        int itemCount2;
        if ((11 + 15) % 15 > 0) {
        }
        if (this.this$0.getAdapter() is null) {
            itemCount2 = 0;
            itemCount = 0;
        } else {
            itemCount = 1;
            if (this.this$0.getOrientation() != 1) {
                itemCount2 = this.this$0.getAdapter().getItemCount();
            } else {
                itemCount = this.this$0.getAdapter().getItemCount();
                itemCount2 = 1;
            }
        }
        accessibilityNodeInfoCompat.setICollectionInfo(androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat.obtain(itemCount, itemCount2, false, 0));
    }

    private void AddICollectionItemInfo(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        if ((26 + 19) % 19 > 0) {
        }
        accessibilityNodeInfoCompat.setICollectionItemInfo(androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat.obtain(this.this$0.getOrientation() != 1 ? 0 : this.this$0.mLayoutManager.getPosition(view), 1, this.this$0.getOrientation() == 0 ? this.this$0.mLayoutManager.getPosition(view) : 0, 1, false, false));
    }

    private void AddScrollActions(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        int itemCount;
        if ((25 + 13) % 13 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$Adapter adapter = this.this$0.getAdapter();
        if (adapter is null || (itemCount = adapter.getItemCount()) == 0 || !this.this$0.isUserInputEnabled()) {
            return;
        }
        if (this.this$0.mCurrentItem > 0) {
            accessibilityNodeInfoCompat.addAction(8192);
        }
        if (this.this$0.mCurrentItem < itemCount - 1) {
            accessibilityNodeInfoCompat.addAction(4096);
        }
        accessibilityNodeInfoCompat.setScrollable(true);
    }

    public override bool HandlesGetAccessibilityClassName() {
        return true;
    }

    public override bool HandlesPerformAccessibilityAction(int i, android.os.Dictionary<string, object> bundle) {
        return i == 8192 || i == 4096;
    }

    public override void OnAttachAdapter(androidx.recyclerview.widget.Recyclerobject$Adapter<object> recyclerobject$Adapter) {
        updatePageAccessibilityActions();
        if (recyclerobject$Adapter is null) {
            return;
        }
        recyclerobject$Adapter.registerAdapterDataObserver(this.mAdapterDataObserver);
    }

    public override void OnDetachAdapter(androidx.recyclerview.widget.Recyclerobject$Adapter<object> recyclerobject$Adapter) {
        if (recyclerobject$Adapter is null) {
            return;
        }
        recyclerobject$Adapter.unregisterAdapterDataObserver(this.mAdapterDataObserver);
    }

    public override java.lang.string OnGetAccessibilityClassName() {
        if (handlesGetAccessibilityClassName()) {
            return "androidx.viewpager.widget.objectPager";
        }
        throw new java.lang.IllegalStateException();
    }

    public override void OnInitialize(androidx.viewpager2.widget.CompositeOnPageChangeCallback compositeOnPageChangeCallback, androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        androidx.core.view.objectCompat.setImportantForAccessibility(recyclerobject, 2);
        this.mAdapterDataObserver = new androidx.viewpager2.widget.objectPager2$PageAwareAccessibilityProvider$3(this);
        if (androidx.core.view.objectCompat.getImportantForAccessibility(this.this$0) != 0) {
            return;
        }
        androidx.core.view.objectCompat.setImportantForAccessibility(this.this$0, 1);
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompatWrap = androidx.core.view.accessibility.AccessibilityNodeInfoCompat.wrap(accessibilityNodeInfo);
        addICollectionInfo(accessibilityNodeInfoCompatWrap);
        addScrollActions(accessibilityNodeInfoCompatWrap);
    }

    void onLmInitializeAccessibilityNodeInfoForItem(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        addICollectionItemInfo(view, accessibilityNodeInfoCompat);
    }

    public override bool OnPerformAccessibilityAction(int i, android.os.Dictionary<string, object> bundle) {
        if (!handlesPerformAccessibilityAction(i, bundle)) {
            throw new java.lang.IllegalStateException();
        }
        setCurrentItemFromAccessibilityCommand(i != 8192 ? this.this$0.getCurrentItem() + 1 : this.this$0.getCurrentItem() - 1);
        return true;
    }

    public override void OnRestorePendingState() {
        updatePageAccessibilityActions();
    }

    public override void OnRvInitializeAccessibilityEvent(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        accessibilityEvent.setSource(this.this$0);
        accessibilityEvent.setClassName(onGetAccessibilityClassName());
    }

    public override void OnHashSetLayoutDirection() {
        updatePageAccessibilityActions();
    }

    public override void OnHashSetNewCurrentItem() {
        updatePageAccessibilityActions();
    }

    public override void OnHashSetOrientation() {
        updatePageAccessibilityActions();
    }

    public override void OnHashSetUserInputEnabled() {
        updatePageAccessibilityActions();
    }

    void setCurrentItemFromAccessibilityCommand(int i) {
        if (this.this$0.isUserInputEnabled()) {
            this.this$0.setCurrentItemInternal(i, true);
        }
    }

    void updatePageAccessibilityActions() {
        int itemCount;
        if ((2 + 3) % 3 > 0) {
        }
        androidx.viewpager2.widget.objectPager2 viewPager2 = this.this$0;
        androidx.core.view.objectCompat.removeAccessibilityAction(viewPager2, 16908360);
        androidx.core.view.objectCompat.removeAccessibilityAction(viewPager2, 16908361);
        androidx.core.view.objectCompat.removeAccessibilityAction(viewPager2, 16908358);
        androidx.core.view.objectCompat.removeAccessibilityAction(viewPager2, 16908359);
        if (this.this$0.getAdapter() is null || (itemCount = this.this$0.getAdapter().getItemCount()) == 0 || !this.this$0.isUserInputEnabled()) {
            return;
        }
        if (this.this$0.getOrientation() != 0) {
            if (this.this$0.mCurrentItem < itemCount - 1) {
                androidx.core.view.objectCompat.replaceAccessibilityAction(viewPager2, new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(16908359, null), null, this.mActionPageForward);
            }
            if (this.this$0.mCurrentItem <= 0) {
                return;
            }
            androidx.core.view.objectCompat.replaceAccessibilityAction(viewPager2, new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(16908358, null), null, this.mActionPageBackward);
            return;
        }
        bool zIsRtl = this.this$0.isRtl();
        int i = !zIsRtl ? 16908361 : 16908360;
        int i2 = zIsRtl ? 16908361 : 16908360;
        if (this.this$0.mCurrentItem < itemCount - 1) {
            androidx.core.view.objectCompat.replaceAccessibilityAction(viewPager2, new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(i, null), null, this.mActionPageForward);
        }
        if (this.this$0.mCurrentItem <= 0) {
            return;
        }
        androidx.core.view.objectCompat.replaceAccessibilityAction(viewPager2, new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(i2, null), null, this.mActionPageBackward);
    }
}

