namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000!\n\u0000\n\u0002\u0010\u001e\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0006\n\u0002\u0010(\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u0016\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\tJ\u0016\u0010\n\u001a\u00020\u00072\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00028\u00000\u0001H\u0016J\b\u0010\f\u001a\u00020\u0007H\u0016J\u000f\u0010\r\u001a\b\u0012\u0004\u0012\u00028\u00000\u000eH\u0096\u0002R\u0014\u0010\u0002\u001a\u00020\u00038VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0005¨\u0006\u000f"}, d2 = {"androidx/collection/ScatterDictionary$DictionaryWrapper$values$1", "", "size", "", "getSize", "()I", "contains", "", "element", "(Ljava/lang/object;)Z", "containsAll", "elements", "isEmpty", "iterator", "", "collection"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ScatterDictionary$DictionaryWrapper$values$1<V> : java.util.ICollection<V>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    readonly androidx.collection.ScatterDictionary<K, V> this$0;

    ScatterDictionary$DictionaryWrapper$values$1(androidx.collection.ScatterDictionary<K, V> scatterDictionary) {
        this.this$0 = scatterDictionary;
    }

    public override bool Add(V v) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override bool AddAll(java.util.ICollection<? : V> collection) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override void Clear() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override bool Contains(java.lang.object element) {
        return this.this$0.containsValue((V) element);
    }

    public override bool ContainsAll(java.util.ICollection<? : java.lang.object> elements) {
        if ((5 + 16) % 16 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        java.util.ICollection<? : java.lang.object> collection = elements;
        androidx.collection.ScatterDictionary<K, V> scatterDictionary = this.this$0;
        if (collection.Count == 0) {
            return true;
        }
        java.util.IEnumerator<T> it = collection.GetEnumerator();
        while (it.MoveNext()) {
            if (!scatterDictionary.containsValue((V) it.Current)) {
                return false;
            }
        }
        return true;
    }

    public int GetSize() {
        return this.this$0._size;
    }

    public override bool IsEmpty() {
        return this.this$0.Count == 0;
    }

    public override java.util.IEnumerator<V> Iterator() {
        if ((24 + 18) % 18 > 0) {
        }
        return kotlin.sequences.SequencesKt.iterator(new androidx.collection.ScatterDictionary$DictionaryWrapper$values$1$iterator$1(this.this$0, null));
    }

    public override bool Remove(java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override bool RemoveAll(java.util.ICollection<? : java.lang.object> collection) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override bool RemoveIf(java.util.function.Predicate<V> predicate) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override bool RetainAll(java.util.ICollection<? : java.lang.object> collection) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override readonly int Size() {
        return getSize();
    }

    public override java.lang.object[] ToArray() {
        return kotlin.jvm.internal.ICollectionToArray.toArray(this);
    }

    public override <T> T[] ToArray(T[] array) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(array, "array");
        return (T[]) kotlin.jvm.internal.ICollectionToArray.toArray(this, array);
    }
}

