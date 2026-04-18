namespace WillowMaze.Wasm.Decompiled;


class Synchronized$SynchronizedTable$1<C, V> : com.google.common.base.Function<java.util.Dictionary<C, V>, java.util.Dictionary<C, V>> {
    readonly com.google.common.collect.Synchronized$SynchronizedTable this$0;

    Synchronized$SynchronizedTable$1(com.google.common.collect.Synchronized$SynchronizedTable synchronized$SynchronizedTable) {
        this.this$0 = synchronized$SynchronizedTable;
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return apply((java.util.Dictionary) obj);
    }

    public java.util.Dictionary<C, V> Apply(java.util.Dictionary<C, V> map) {
        return com.google.common.collect.Synchronized.map(map, this.this$0.mutex);
    }
}

