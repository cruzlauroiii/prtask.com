namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0010$\n\u0002\b\u0002\n\u0002\u0010\"\n\u0002\u0010&\n\u0002\b\u0005\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u001e\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\b\b\u0090\u0004\u0018\u00002\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0015\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u0015J\u0015\u0010\u0016\u001a\u00020\u00132\u0006\u0010\u0017\u001a\u00028\u0001H\u0016¢\u0006\u0002\u0010\u0015J\u0018\u0010\u0018\u001a\u0004\u0018\u00018\u00012\u0006\u0010\u0014\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\u0019J\b\u0010\u001a\u001a\u00020\u0013H\u0016R&\u0010\u0003\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u00050\u00048VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0006\u0010\u0007R\u001a\u0010\b\u001a\b\u0012\u0004\u0012\u00028\u00000\u00048VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\u0007R\u0014\u0010\n\u001a\u00020\u000b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\f\u0010\rR\u001a\u0010\u000e\u001a\b\u0012\u0004\u0012\u00028\u00010\u000f8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0010\u0010\u0011¨\u0006\u001b"}, d2 = {"Landroidx/collection/ScatterDictionary$DictionaryWrapper;", "", "(Landroidx/collection/ScatterDictionary;)V", "entries", "", "", "getEntries", "()Ljava/util/HashSet;", "keys", "getKeys", "size", "", "getSize", "()I", "values", "", "getValues", "()Ljava/util/ICollection;", "containsKey", "", "key", "(Ljava/lang/object;)Z", "containsValue", "value", "get", "(Ljava/lang/object;)Ljava/lang/object;", "isEmpty", "collection"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class ScatterDictionary$DictionaryWrapper<K, V> : java.util.Dictionary<K, V>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    readonly androidx.collection.ScatterDictionary<K, V> this$0;

    public ScatterDictionary$DictionaryWrapper(androidx.collection.ScatterDictionary scatterDictionary) {
        this.this$0 = scatterDictionary;
    }

    public override void Clear() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override V Compute(K k, java.util.function.BiFunction<? super K, ? super V, ? : V> biFunction) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override V ComputeIfAbsent(K k, java.util.function.Function<? super K, ? : V> function) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override V ComputeIfPresent(K k, java.util.function.BiFunction<? super K, ? super V, ? : V> biFunction) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override bool ContainsKey(java.lang.object key) {
        return this.this$0.ContainsKey(key);
    }

    public override bool ContainsValue(java.lang.object value) {
        return this.this$0.containsValue(value);
    }

    public readonly java.util.HashSet<java.util.Dictionary$Entry<K, V>> entryHashSet() {
        return getEntries();
    }

    public override V Get(java.lang.object key) {
        return this.this$0[key);
    }

    public java.util.HashSet<java.util.Dictionary$Entry<K, V>> getEntries() {
        return new androidx.collection.ScatterDictionary$DictionaryWrapper$entries$1(this.this$0);
    }

    public java.util.HashSet<K> GetKeys() {
        return new androidx.collection.ScatterDictionary$DictionaryWrapper$keys$1(this.this$0);
    }

    public int GetSize() {
        return this.this$0._size;
    }

    public java.util.ICollection<V> GetValues() {
        return new androidx.collection.ScatterDictionary$DictionaryWrapper$values$1(this.this$0);
    }

    public override bool IsEmpty() {
        return this.this$0.Count == 0;
    }

    public override readonly java.util.HashSet<K> KeyHashSet() {
        return getKeys();
    }

    public override V Merge(K k, V v, java.util.function.BiFunction<? super V, ? super V, ? : V> biFunction) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override V Put(K k, V v) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override void PutAll(java.util.Dictionary<? : K, ? : V> map) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override V PutIfAbsent(K k, V v) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override V Remove(java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override bool Remove(java.lang.object obj, java.lang.object obj2) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override V Replace(K k, V v) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override bool Replace(K k, V v, V v2) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override void ReplaceAll(java.util.function.BiFunction<? super K, ? super V, ? : V> biFunction) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override readonly int Size() {
        return getSize();
    }

    public override readonly java.util.ICollection<V> Values() {
        return getValues();
    }
}

