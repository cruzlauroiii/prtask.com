namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class ForwardingListMultimap<K, V> : com.google.common.collect.ForwardingMultimap<K, V> : com.google.common.collect.ListMultimap<K, V> {
    protected ForwardingListMultimap() {
    }

    protected override abstract com.google.common.collect.ListMultimap<K, V> Delegate();

    protected override com.google.common.collect.Multimap Delegate() {
        return delegate();
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    public override java.util.ICollection Get(@com.google.common.collect.ParametricNullness java.lang.object obj) {
        return get(obj);
    }

    public override java.util.List<V> Get(@com.google.common.collect.ParametricNullness K k) {
        return delegate()[(java.lang.object) k);
    }

    public override java.util.ICollection RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return removeAll(obj);
    }

    public override java.util.List<V> RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return delegate().removeAll(obj);
    }

    public override java.util.ICollection ReplaceValues(@com.google.common.collect.ParametricNullness java.lang.object obj, java.lang.IEnumerable iterable) {
        return replaceValues(obj, iterable);
    }

    public override java.util.List<V> ReplaceValues(@com.google.common.collect.ParametricNullness K k, java.lang.IEnumerable<? : V> iterable) {
        return delegate().replaceValues((java.lang.object) k, (java.lang.IEnumerable) iterable);
    }
}

