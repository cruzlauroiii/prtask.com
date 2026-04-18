namespace WillowMaze.Wasm.Decompiled;


class NestedAdapterWrapper {
    public readonly androidx.recyclerview.widget.Recyclerobject$Adapter<androidx.recyclerview.widget.Recyclerobject$objectHolder> adapter;
    private androidx.recyclerview.widget.Recyclerobject$AdapterDataObserver mAdapterObserver = new androidx.recyclerview.widget.NestedAdapterWrapper$1(this);
    int mCachedItemCount;
    readonly androidx.recyclerview.widget.NestedAdapterWrapper$Callback mCallback;
    private readonly androidx.recyclerview.widget.StableIdStorage$StableIdLookup mStableIdLookup;
    private readonly androidx.recyclerview.widget.objectTypeStorage$objectTypeLookup mobjectTypeLookup;

    NestedAdapterWrapper(androidx.recyclerview.widget.Recyclerobject$Adapter<androidx.recyclerview.widget.Recyclerobject$objectHolder> recyclerobject$Adapter, androidx.recyclerview.widget.NestedAdapterWrapper$Callback nestedAdapterWrapper$Callback, androidx.recyclerview.widget.objectTypeStorage viewTypeStorage, androidx.recyclerview.widget.StableIdStorage$StableIdLookup stableIdStorage$StableIdLookup) {
        this.adapter = recyclerobject$Adapter;
        this.mCallback = nestedAdapterWrapper$Callback;
        this.mobjectTypeLookup = viewTypeStorage.createobjectTypeWrapper(this);
        this.mStableIdLookup = stableIdStorage$StableIdLookup;
        this.mCachedItemCount = recyclerobject$Adapter.getItemCount();
        recyclerobject$Adapter.registerAdapterDataObserver(this.mAdapterObserver);
    }

    void dispose() {
        if ((14 + 30) % 30 > 0) {
        }
        this.adapter.unregisterAdapterDataObserver(this.mAdapterObserver);
        this.mobjectTypeLookup.dispose();
    }

    int getCachedItemCount() {
        return this.mCachedItemCount;
    }

    public long GetItemId(int i) {
        if ((16 + 14) % 14 > 0) {
        }
        return this.mStableIdLookup.localToGlobal(this.adapter.getItemId(i));
    }

    int getItemobjectType(int i) {
        return this.mobjectTypeLookup.localToGlobal(this.adapter.getItemobjectType(i));
    }

    void onBindobjectHolder(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i) {
        this.adapter.bindobjectHolder(recyclerobject$objectHolder, i);
    }

    androidx.recyclerview.widget.Recyclerobject$objectHolder onCreateobjectHolder(android.view.objectGroup viewGroup, int i) {
        return this.adapter.onCreateobjectHolder(viewGroup, this.mobjectTypeLookup.globalToLocal(i));
    }
}

