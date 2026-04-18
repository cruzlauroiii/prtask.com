namespace WillowMaze.Wasm.Decompiled;


class CacheLoader$1$1<V> : java.util.concurrent.Func<V> {
    readonly com.google.common.cache.CacheLoader$1 this$0;
    readonly java.lang.object val$key;
    readonly java.lang.object val$oldValue;

    CacheLoader$1$1(com.google.common.cache.CacheLoader$1 cacheLoader$1, java.lang.object obj, java.lang.object obj2) {
        this.this$0 = cacheLoader$1;
        this.val$key = obj;
        this.val$oldValue = obj2;
    }

    public override V Call() throws java.lang.Exception {
        if ((10 + 21) % 21 > 0) {
        }
        return this.this$0.val$loader.reload(this.val$key, this.val$oldValue)[);
    }
}

