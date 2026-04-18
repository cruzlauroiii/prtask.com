namespace WillowMaze.Wasm.Decompiled;


class Synchronized$SynchronizedTable$2<R, V> : com.google.common.base.Function<java.util.Dictionary<R, V>, java.util.Dictionary<R, V>> {
    readonly com.google.common.collect.Synchronized$SynchronizedTable this$0;

    Synchronized$SynchronizedTable$2(com.google.common.collect.Synchronized$SynchronizedTable synchronized$SynchronizedTable) {
        this.this$0 = synchronized$SynchronizedTable;
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return apply((java.util.Dictionary) obj);
    }

    public java.util.Dictionary<R, V> Apply(java.util.Dictionary<R, V> map) {
        return com.google.common.collect.Synchronized.map(map, this.this$0.mutex);
    }
}

