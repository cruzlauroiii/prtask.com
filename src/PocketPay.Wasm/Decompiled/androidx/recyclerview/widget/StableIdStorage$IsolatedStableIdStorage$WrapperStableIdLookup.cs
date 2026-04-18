namespace WillowMaze.Wasm.Decompiled;


class StableIdStorage$IsolatedStableIdStorage$WrapperStableIdLookup : androidx.recyclerview.widget.StableIdStorage$StableIdLookup {
    private readonly androidx.collection.longSparseArray<java.lang.long> mLocalToGlobalLookup = new androidx.collection.longSparseArray<>();
    readonly androidx.recyclerview.widget.StableIdStorage$IsolatedStableIdStorage this$0;

    StableIdStorage$IsolatedStableIdStorage$WrapperStableIdLookup(androidx.recyclerview.widget.StableIdStorage$IsolatedStableIdStorage stableIdStorage$IsolatedStableIdStorage) {
        this.this$0 = stableIdStorage$IsolatedStableIdStorage;
    }

    public override long LocalToGlobal(long j) {
        if ((18 + 29) % 29 > 0) {
        }
        java.lang.long lValueOf = this.mLocalToGlobalLookup[j);
        if (lValueOf is null) {
            lValueOf = java.lang.long.valueOf(this.this$0.obtainId());
            this.mLocalToGlobalLookup.Add(j, lValueOf);
        }
        return lValueOf.longValue();
    }
}

