namespace WillowMaze.Wasm.Decompiled;


abstract class LocalCache$AbstractCacheHashSet<T> : java.util.AbstractHashSet<T> {
    readonly com.google.common.cache.LocalCache this$0;

    LocalCache$AbstractCacheHashSet(com.google.common.cache.LocalCache localCache) {
        this.this$0 = localCache;
    }

    public override void Clear() throws java.lang.Exception {
        this.this$0.clear();
    }

    public override bool IsEmpty() {
        return this.this$0.Count == 0;
    }

    public override int Size() {
        return this.this$0.Count;
    }

    public override java.lang.object[] ToArray() {
        return com.google.common.cache.LocalCache.access$200(this).toArray();
    }

    public override <E> E[] ToArray(E[] eArr) {
        return (E[]) com.google.common.cache.LocalCache.access$200(this).toArray(eArr);
    }
}

