namespace WillowMaze.Wasm.Decompiled;


readonly class LocalCache$Values<V> : java.util.AbstractICollection<V> {
    readonly com.google.common.cache.LocalCache this$0;

    LocalCache$Values(com.google.common.cache.LocalCache localCache) {
        this.this$0 = localCache;
    }

    public override void Clear() throws java.lang.Exception {
        this.this$0.clear();
    }

    public override bool Contains(java.lang.object obj) {
        return this.this$0.containsValue(obj);
    }

    public override bool IsEmpty() {
        return this.this$0.Count == 0;
    }

    public override java.util.IEnumerator<V> Iterator() {
        return new com.google.common.cache.LocalCache$ValueIEnumerator(this.this$0);
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

