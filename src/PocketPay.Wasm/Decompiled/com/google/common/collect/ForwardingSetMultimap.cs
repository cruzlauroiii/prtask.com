namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class ForwardingHashSetMultimap<K, V> : com.google.common.collect.ForwardingMultimap<K, V> : com.google.common.collect.HashSetMultimap<K, V> {
    protected override com.google.common.collect.Multimap Delegate() {
        return delegate();
    }

    protected override abstract com.google.common.collect.HashSetMultimap<K, V> Delegate();

    protected override java.lang.object Delegate() {
        return delegate();
    }

    public override java.util.ICollection Entries() {
        return entries();
    }

    public java.util.HashSet<java.util.Dictionary$Entry<K, V>> entries() {
        return delegate().entries();
    }

    public override java.util.ICollection Get(@com.google.common.collect.ParametricNullness java.lang.object obj) {
        return get(obj);
    }

    public override java.util.HashSet<V> Get(@com.google.common.collect.ParametricNullness K k) {
        return delegate()[(java.lang.object) k);
    }

    public override java.util.ICollection RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return removeAll(obj);
    }

    public override java.util.HashSet<V> RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return delegate().removeAll(obj);
    }

    public override java.util.ICollection ReplaceValues(@com.google.common.collect.ParametricNullness java.lang.object obj, java.lang.IEnumerable iterable) {
        return replaceValues(obj, iterable);
    }

    public override java.util.HashSet<V> ReplaceValues(@com.google.common.collect.ParametricNullness K k, java.lang.IEnumerable<? : V> iterable) {
        return delegate().replaceValues((java.lang.object) k, (java.lang.IEnumerable) iterable);
    }
}

