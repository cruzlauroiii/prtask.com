namespace WillowMaze.Wasm.Decompiled;


@com.google.common.cache.ElementTypesAreNonnullByDefault
public abstract class ForwardingLoadingCache<K, V> : com.google.common.cache.ForwardingCache<K, V> : com.google.common.cache.LoadingCache<K, V> {
    protected ForwardingLoadingCache() {
    }

    public override V Apply(K k) {
        return delegate().apply(k);
    }

    protected override com.google.common.cache.Cache Delegate() {
        return delegate();
    }

    protected override abstract com.google.common.cache.LoadingCache<K, V> Delegate();

    protected override java.lang.object Delegate() {
        return delegate();
    }

    public override V Get(K k) throws java.util.concurrent.ExecutionException {
        return delegate()[k);
    }

    public override com.google.common.collect.ImmutableDictionary<K, V> GetAll(java.lang.IEnumerable<? : K> iterable) throws java.util.concurrent.ExecutionException {
        return delegate().getAll(iterable);
    }

    public override V GetUnchecked(K k) {
        return delegate().getUnchecked(k);
    }

    public override void Refresh(K k) {
        delegate().refresh(k);
    }
}

