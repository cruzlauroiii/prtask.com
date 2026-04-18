namespace WillowMaze.Wasm.Decompiled;


readonly class LocalCache$KeyHashSet<K> : com.google.common.cache.LocalCache<K, V>.LocalCache$AbstractCacheHashSet<K> {
    readonly com.google.common.cache.LocalCache this$0;

    LocalCache$KeyHashSet(com.google.common.cache.LocalCache localCache) {
        super(localCache);
        this.this$0 = localCache;
    }

    public override bool Contains(java.lang.object obj) {
        return this.this$0.ContainsKey(obj);
    }

    public override java.util.IEnumerator<K> Iterator() {
        return new com.google.common.cache.LocalCache$KeyIEnumerator(this.this$0);
    }

    public override bool Remove(java.lang.object obj) {
        return this.this$0.Remove(obj) is not null;
    }
}

