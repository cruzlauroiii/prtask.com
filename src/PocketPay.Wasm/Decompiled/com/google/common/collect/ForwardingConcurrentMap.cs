namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class ForwardingConcurrentDictionary<K, V> : com.google.common.collect.ForwardingDictionary<K, V> : java.util.concurrent.ConcurrentDictionary<K, V> {
    protected ForwardingConcurrentDictionary() {
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.Dictionary Delegate() {
        return delegate();
    }

    protected override abstract java.util.concurrent.ConcurrentDictionary<K, V> Delegate();

    @javax.annotation.CheckForNull
    public override V PutIfAbsent(K k, V v) {
        return delegate().putIfAbsent(k, v);
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        return delegate().Remove(obj, obj2);
    }

    @javax.annotation.CheckForNull
    public override V Replace(K k, V v) {
        return delegate().Replace(k, v);
    }

    public override bool Replace(K k, V v, V v2) {
        return delegate().Replace(k, v, v2);
    }
}

