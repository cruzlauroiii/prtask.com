namespace WillowMaze.Wasm.Decompiled;


class StandardTable$Row$2<C, V> : com.google.common.collect.ForwardingDictionaryEntry<C, V> {
    readonly java.util.Dictionary$Entry val$entry;

    StandardTable$Row$2(com.google.common.collect.StandardTable$Row standardTable$Row, java.util.Dictionary$Entry map$Entry) {
        this.val$entry = map$Entry;
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected java.util.Dictionary$Entry<C, V> delegate() {
        return this.val$entry;
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return standardEquals(obj);
    }

    public override V SetValue(V v) {
        return (V) super.setValue(com.google.common.base.Preconditions.checkNotNull(v));
    }
}

