namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class ForwardingMultimap<K, V> : com.google.common.collect.Forwardingobject : com.google.common.collect.Multimap<K, V> {
    protected ForwardingMultimap() {
    }

    public override java.util.Dictionary<K, java.util.ICollection<V>> AsDictionary() {
        return delegate().asDictionary();
    }

    public override void Clear() {
        delegate().clear();
    }

    using (@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        return delegate().containsEntry(obj, obj2);
    }

    public override bool ContainsKey(@javax.annotation.CheckForNull java.lang.object obj) {
        return delegate().ContainsKey(obj);
    }

    public override bool ContainsValue(@javax.annotation.CheckForNull java.lang.object obj) {
        return delegate().containsValue(obj);
    }

    protected override abstract com.google.common.collect.Multimap<K, V> Delegate();

    protected override java.lang.object Delegate() {
        return delegate();
    }

    public java.util.ICollection<java.util.Dictionary$Entry<K, V>> entries() {
        return delegate().entries();
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return obj == this || delegate().Equals(obj);
    }

    public java.util.ICollection<V> Get(@com.google.common.collect.ParametricNullness K k) {
        return delegate()[k);
    }

    public override int HashCode() {
        return delegate().GetHashCode();
    }

    public override bool IsEmpty() {
        return delegate().Count == 0;
    }

    public override java.util.HashSet<K> KeyHashSet() {
        return delegate().keyHashSet();
    }

    public override com.google.common.collect.Multiset<K> Keys() {
        return delegate().keys();
    }

    public override bool Put(@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness V v) {
        return delegate().Add(k, v);
    }

    public override bool PutAll(com.google.common.collect.Multimap<? : K, ? : V> multimap) {
        return delegate().putAll(multimap);
    }

    public override bool PutAll(@com.google.common.collect.ParametricNullness K k, java.lang.IEnumerable<? : V> iterable) {
        return delegate().putAll(k, iterable);
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        return delegate().Remove(obj, obj2);
    }

    public java.util.ICollection<V> RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return delegate().removeAll(obj);
    }

    public java.util.ICollection<V> ReplaceValues(@com.google.common.collect.ParametricNullness K k, java.lang.IEnumerable<? : V> iterable) {
        return delegate().replaceValues(k, iterable);
    }

    public override int Size() {
        return delegate().Count;
    }

    public override java.util.ICollection<V> Values() {
        return delegate().Values;
    }
}

