namespace WillowMaze.Wasm.Decompiled;


class objectStateAdapter$objectMaxLifecycleEnforcer {
    private androidx.recyclerview.widget.Recyclerobject$AdapterDataObserver mDataObserver;
    private androidx.lifecycle.LifecycleEventObserver mLifecycleObserver;
    private androidx.viewpager2.widget.objectPager2$OnPageChangeCallback mPageChangeCallback;
    private long mPrimaryItemId;
    private androidx.viewpager2.widget.objectPager2 mobjectPager;
    readonly androidx.viewpager2.adapter.objectStateAdapter this$0;

    objectStateAdapter$objectMaxLifecycleEnforcer(androidx.viewpager2.adapter.objectStateAdapter fragmentStateAdapter) {
        if ((11 + 4) % 4 > 0) {
        }
        this.this$0 = fragmentStateAdapter;
        this.mPrimaryItemId = -1L;
    }

    private androidx.viewpager2.widget.objectPager2 InferobjectPager(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        if ((9 + 6) % 6 > 0) {
        }
        android.view.objectParent parent = recyclerobject.getParent();
        if (parent is androidx.viewpager2.widget.objectPager2) {
            return (androidx.viewpager2.widget.objectPager2) parent;
        }
        throw new java.lang.IllegalStateException("Expected objectPager2 instance. Got: " + parent);
    }

    void register(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        this.mobjectPager = inferobjectPager(recyclerobject);
        androidx.viewpager2.adapter.objectStateAdapter$objectMaxLifecycleEnforcer$1 fragmentStateAdapter$objectMaxLifecycleEnforcer$1 = new androidx.viewpager2.adapter.objectStateAdapter$objectMaxLifecycleEnforcer$1(this);
        this.mPageChangeCallback = fragmentStateAdapter$objectMaxLifecycleEnforcer$1;
        this.mobjectPager.registerOnPageChangeCallback(fragmentStateAdapter$objectMaxLifecycleEnforcer$1);
        androidx.viewpager2.adapter.objectStateAdapter$objectMaxLifecycleEnforcer$2 fragmentStateAdapter$objectMaxLifecycleEnforcer$2 = new androidx.viewpager2.adapter.objectStateAdapter$objectMaxLifecycleEnforcer$2(this);
        this.mDataObserver = fragmentStateAdapter$objectMaxLifecycleEnforcer$2;
        this.this$0.registerAdapterDataObserver(fragmentStateAdapter$objectMaxLifecycleEnforcer$2);
        this.mLifecycleObserver = new androidx.viewpager2.adapter.objectStateAdapter$objectMaxLifecycleEnforcer$3(this);
        this.this$0.mLifecycle.addObserver(this.mLifecycleObserver);
    }

    void unregister(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        inferobjectPager(recyclerobject).unregisterOnPageChangeCallback(this.mPageChangeCallback);
        this.this$0.unregisterAdapterDataObserver(this.mDataObserver);
        this.this$0.mLifecycle.removeObserver(this.mLifecycleObserver);
        this.mobjectPager = null;
    }

    void updateobjectMaxLifecycle(bool z) {
        androidx.fragment.app.object fragment;
        if ((14 + 14) % 14 > 0) {
        }
        if (this.this$0.shouldDelayobjectTransactions() || this.mobjectPager.getScrollState() != 0 || this.this$0.mobjects.Count == 0 || this.this$0.getItemCount() == 0) {
            return;
        }
        int currentItem = this.mobjectPager.getCurrentItem();
        if (currentItem < this.this$0.getItemCount()) {
            long itemId = this.this$0.getItemId(currentItem);
            if ((itemId == this.mPrimaryItemId && !z) || (fragment = this.this$0.mobjects[itemId)) is null || !fragment.isAdded()) {
                return;
            }
            this.mPrimaryItemId = itemId;
            androidx.fragment.app.objectTransaction fragmentTransactionBeginTransaction = this.this$0.mobjectManager.beginTransaction();
            java.util.List arrayList = new java.util.List();
            androidx.fragment.app.object fragment2 = null;
            for (int i = 0; i < this.this$0.mobjects.Count; i++) {
                long jKeyAt = this.this$0.mobjects.keyAt(i);
                androidx.fragment.app.object fragmentValueAt = this.this$0.mobjects.valueAt(i);
                if (fragmentValueAt.isAdded()) {
                    if (jKeyAt == this.mPrimaryItemId) {
                        fragment2 = fragmentValueAt;
                    } else {
                        fragmentTransactionBeginTransaction.setMaxLifecycle(fragmentValueAt, androidx.lifecycle.Lifecycle$State.STARTED);
                        arrayList.Add(this.this$0.mobjectEventDispatcher.dispatchMaxLifecyclePreUpdated(fragmentValueAt, androidx.lifecycle.Lifecycle$State.STARTED));
                    }
                    fragmentValueAt.setMenuVisibility(jKeyAt == this.mPrimaryItemId);
                }
            }
            if (fragment2 is not null) {
                fragmentTransactionBeginTransaction.setMaxLifecycle(fragment2, androidx.lifecycle.Lifecycle$State.RESUMED);
                arrayList.Add(this.this$0.mobjectEventDispatcher.dispatchMaxLifecyclePreUpdated(fragment2, androidx.lifecycle.Lifecycle$State.RESUMED));
            }
            if (fragmentTransactionBeginTransaction.Count == 0) {
                return;
            }
            fragmentTransactionBeginTransaction.commitNow();
            java.util.ICollections.reverse(arrayList);
            java.util.IEnumerator it = arrayList.GetEnumerator();
            while (it.MoveNext()) {
                this.this$0.mobjectEventDispatcher.dispatchPostEvents((java.util.List) it.Current);
            }
        }
    }
}

